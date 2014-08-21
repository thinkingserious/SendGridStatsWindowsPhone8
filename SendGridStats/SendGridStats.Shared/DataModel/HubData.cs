using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using SendGridStats.Models;

namespace SendGridStats.DataModel
{
	public interface IItem
	{
		String Name { get; set; }

		String Id { get; set; }
	}

	[DataContract]
	public class HubContainer
		: NotifyPropertyChangedBase
	{
		[DataMember(Name="hubs")]
		public ObservableCollection<Hub> Hubs { get; set; } 
	}

	[DataContract]
    public class Hub
		: NotifyPropertyChangedBase, IItem
    {
		[DataMember(Name="name")]
		public String Name { get; set; }

		[DataMember(Name = "id")]
		public String Id { get; set; }

		[DataMember(Name = "items")]
		public ObservableCollection<HubItem> Items { get; set; } 
    }

	[DataContract]
	public class HubItem
		: NotifyPropertyChangedBase, IItem
	{
		[DataMember(Name = "name")]
		public String Name { get; set; }

		[DataMember(Name = "id")]
		public String Id { get; set; }
	}
}
