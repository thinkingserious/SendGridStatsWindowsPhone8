using System;
using System.Collections.ObjectModel;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SendGridStats.Common;
using SendGridStats.DataModel;
using SendGridStats.ViewModels.Pages;

namespace SendGridStats.Pages
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class StatsPage
	{
		private readonly NavigationHelper _navigationHelper;

		public StatsPage()
		{
			InitializeComponent();

			_navigationHelper = new NavigationHelper(this);
			_navigationHelper.LoadState += NavigationHelper_LoadState;
			_navigationHelper.SaveState += NavigationHelper_SaveState;
		}

		private void StatsItem_Click(object sender, ItemClickEventArgs e)
		{
			Frame.Navigate(typeof (StatsDetails), e.ClickedItem);
		}

		private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
		{
			// TODO: Create an appropriate data model for your problem domain to replace the sample data.
		}

		private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
		{
			// TODO: Save the unique state of the page here.
		}

		#region NavigationHelper registration

		protected override async void OnNavigatedTo(NavigationEventArgs e)
		{
			_navigationHelper.OnNavigatedTo(e);

			// Show Progress UI
			StatusBar.GetForCurrentView().ProgressIndicator.Text = "Updating Email Stats...";
			await StatusBar.GetForCurrentView().ProgressIndicator.ShowAsync();

			// do stuff
			var viewModel = DataContext as EmailStatsViewModel;
			var id = e.Parameter as String;
			var stats = new ObservableCollection<EmailStats>();
			switch (id)
			{
				case "stats-item-recent":
					stats = await App.SendGridApi.GetStats(1, 0);
					if (viewModel != null) viewModel.Title = "Recent Stats";
					break;

				case "stats-item-totals":
					stats = await App.SendGridApi.GetStats(1, 1);
					if (viewModel != null) viewModel.Title = "All Stats";
					break;
			}

			if (viewModel != null) viewModel.EmailStats = stats;

			// Hide Progress UI
			StatusBar.GetForCurrentView().ProgressIndicator.Text = String.Empty;
			await StatusBar.GetForCurrentView().ProgressIndicator.HideAsync();
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			_navigationHelper.OnNavigatedFrom(e);
		}

		#endregion
	}
}
