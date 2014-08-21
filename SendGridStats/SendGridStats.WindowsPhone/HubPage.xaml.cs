using Windows.Graphics.Display;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SendGridStats.Common;
using SendGridStats.DataModel;
using SendGridStats.Pages;

namespace SendGridStats
{
	/// <summary>
	/// A page that displays a grouped collection of items.
	/// </summary>
	public partial class HubPage
	{
		private readonly NavigationHelper _navigationHelper;

		public HubPage()
		{
			InitializeComponent();

			// Hub is only supported in Portrait orientation
			DisplayInformation.AutoRotationPreferences = DisplayOrientations.Portrait;

			NavigationCacheMode = NavigationCacheMode.Required;

			_navigationHelper = new NavigationHelper(this);
			_navigationHelper.LoadState += NavigationHelper_LoadState;
			_navigationHelper.SaveState += NavigationHelper_SaveState;
		}
		
		/// <summary>
		/// Shows the details of a clicked group in the <see cref="SectionPage"/>.
		/// </summary>
		/// <param name="sender">The source of the click event.</param>
		/// <param name="e">Details about the click event.</param>
		private void GroupSection_ItemClick(object sender, ItemClickEventArgs e)
		{
			var hubId = ((HubItem)e.ClickedItem).Id;
			switch (hubId)
			{
				case "stats-item-recent":
                    			Frame.Navigate(typeof(StatsPage), hubId);
                    			break;
				case "stats-item-totals":
                    			Frame.Navigate(typeof(StatsPage), hubId);
					break;
			}
		}

		/// <summary>
		/// Populates the page with content passed during navigation.  Any saved state is also
		/// provided when recreating a page from a prior session.
		/// </summary>
		/// <param name="sender">
		/// The source of the event; typically <see cref="NavigationHelper"/>
		/// </param>
		/// <param name="e">Event data that provides both the navigation parameter passed to
		/// <see cref="Frame.Navigate(Type, object)"/> when this page was initially requested and
		/// a dictionary of state preserved by this page during an earlier
		/// session.  The state will be null the first time a page is visited.</param>
		private async void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
		{
			// TODO: Create an appropriate data model for your problem domain to replace the sample data
			//var sampleDataGroups = await SampleDataSource.GetGroupsAsync();
			//this.DefaultViewModel["Groups"] = sampleDataGroups;
		}

		/// <summary>
		/// Preserves state associated with this page in case the application is suspended or the
		/// page is discarded from the navigation cache.  Values must conform to the serialization
		/// requirements of <see cref="SuspensionManager.SessionState"/>.
		/// </summary>
		/// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
		/// <param name="e">Event data that provides an empty dictionary to be populated with
		/// serializable state.</param>
		private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
		{
			// TODO: Save the unique state of the page here.
		}

		#region NavigationHelper registration

		/// <summary>
		/// The methods provided in this section are simply used to allow
		/// NavigationHelper to respond to the page's navigation methods.
		/// <para>
		/// Page specific logic should be placed in event handlers for the
		/// <see cref="NavigationHelper.LoadState"/>
		/// and <see cref="NavigationHelper.SaveState"/>.
		/// The navigation parameter is available in the LoadState method
		/// in addition to page state preserved during an earlier session.
		/// </para>
		/// </summary>
		/// <param name="e">Event data that describes how this page was reached.</param>
		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			_navigationHelper.OnNavigatedTo(e);
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			_navigationHelper.OnNavigatedFrom(e);
		}

		#endregion
	}
}
