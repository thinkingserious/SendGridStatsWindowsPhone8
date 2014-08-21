using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556
using SendGridStats.Common;
using SendGridStats.DataModel;

namespace SendGridStats.Pages
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class StatsDetails
	{
		private readonly NavigationHelper _navigationHelper;

		public StatsDetails()
		{
			InitializeComponent();

			_navigationHelper = new NavigationHelper(this);
			_navigationHelper.LoadState += NavigationHelper_LoadState;
			_navigationHelper.SaveState += NavigationHelper_SaveState;
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

		protected override void OnNavigatedTo(NavigationEventArgs e)
		{
			DataContext = e.Parameter as EmailStats;
			_navigationHelper.OnNavigatedTo(e);
		}

		protected override void OnNavigatedFrom(NavigationEventArgs e)
		{
			_navigationHelper.OnNavigatedFrom(e);
		}

		#endregion
	}
}
