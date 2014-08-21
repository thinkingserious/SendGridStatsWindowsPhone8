using System;
using System.Collections.ObjectModel;
using Windows.Storage;
using Newtonsoft.Json;
using SendGridStats.DataModel;
using SendGridStats.Helpers;
using SendGridStats.Models;

namespace SendGridStats.ViewModels
{
	public class HubViewModel
		: NotifyPropertyChangedBase
	{
		public HubViewModel()
		{
			// load data
			var dataUri = new Uri("ms-appx:///DataModel/HubData.json");
			var file = AsyncHelpers.RunSync(() => StorageFile.GetFileFromApplicationUriAsync(dataUri).AsTask());
			var jsonText = AsyncHelpers.RunSync(() => FileIO.ReadTextAsync(file).AsTask());
			Hub = JsonConvert.DeserializeObject<HubContainer>(jsonText).Hubs;
		}

		public ObservableCollection<Hub> Hub
		{
			get { return _hub; }
			set { SetField(ref _hub, value); }
		} 
		private ObservableCollection<Hub> _hub = new ObservableCollection<Hub>(); 
	}
}
