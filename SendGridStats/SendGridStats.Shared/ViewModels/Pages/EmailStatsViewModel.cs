using System;
using System.Collections.ObjectModel;
using SendGridStats.DataModel;
using SendGridStats.Models;

namespace SendGridStats.ViewModels.Pages
{
	public class EmailStatsViewModel
		: NotifyPropertyChangedBase
	{
		public String Title
		{
			get { return _title; }
			set { SetField(ref _title, value); }
		}
		private String _title;

		public ObservableCollection<EmailStats> EmailStats
		{
			get { return _stats; }
			set { SetField(ref _stats, value); }
		}
		private ObservableCollection<EmailStats> _stats = new ObservableCollection<EmailStats>();
	}
}