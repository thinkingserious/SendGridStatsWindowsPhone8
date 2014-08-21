using System;
using System.Net;
using System.Runtime.Serialization;
using SendGridStats.Models;

namespace SendGridStats.DataModel
{
    [DataContract]
    public class EmailStats
		: NotifyPropertyChangedBase
    	{
		[DataMember(Name = "delivered")]
		public int Delivered
		{
	            get { return _delivered; }
	            set { SetField(ref _delivered, value); }
		}
		private int _delivered;

		[DataMember(Name = "unsubscribes")]
		public int Unsubscribes
		{
	            get { return _unsubscribes; }
	            set { SetField(ref _unsubscribes, value); }
		}
        	private int _unsubscribes;

		[DataMember(Name = "invalid_email")]
		public int InvalidEmail
		{
	            get { return _invalid_email; }
	            set { SetField(ref _invalid_email, value); }
		}
        	private int _invalid_email;

		[DataMember(Name = "bounces")]
		public int Bounces
		{
	            get { return _bounces; }
	            set { SetField(ref _bounces, value); }
		}
        	private int _bounces;

        	[DataMember(Name = "repeat_unsubscribes")]
        	public int RepeatUnsubscribes
	        {
	            get { return _repeat_unsubscribes; }
	            set { SetField(ref _repeat_unsubscribes, value); }
	        }
	        private int _repeat_unsubscribes;
	
	        [DataMember(Name = "unique_clicks")]
	        public int UniqueClicks
	        {
	            get { return _unique_clicks; }
	            set { SetField(ref _unique_clicks, value); }
	        }
	        private int _unique_clicks;
	
	        [DataMember(Name = "blocked")]
	        public int Blocked
	        {
	            get { return _blocked; }
	            set { SetField(ref _blocked, value); }
	        }
	        private int _blocked;
	
	        [DataMember(Name = "spam_drop")]
	        public int SpamDrop
	        {
	            get { return _spam_drop; }
	            set { SetField(ref _spam_drop, value); }
	        }
	        private int _spam_drop;
	
	        [DataMember(Name = "repeat_bounces")]
	        public int RepeatBounces
	        {
	            get { return _repeat_bounces; }
	            set { SetField(ref _repeat_bounces, value); }
	        }
	        private int _repeat_bounces;
	
	        [DataMember(Name = "repeat_spamreports")]
	        public int RepeatSpamReports
	        {
	            get { return _repeat_spamreports; }
	            set { SetField(ref _repeat_spamreports, value); }
	        }
	        private int _repeat_spamreports;
	
	        [DataMember(Name = "date")]
	        public String Date
	        {
	            get { return _date; }
	            set { SetField(ref _date, value); }
	        }
	        private String _date;
	
	        [DataMember(Name = "requests")]
	        public int Requests
	        {
	            get { return _requests; }
	            set { SetField(ref _requests, value); }
	        }
	        private int _requests;
	
	        [DataMember(Name = "spamreports")]
	        public int SpamReports
	        {
	            get { return _spamreports; }
	            set { SetField(ref _spamreports, value); }
	        }
	        private int _spamreports;
	
	        [DataMember(Name = "clicks")]
	        public int Clicks
	        {
	            get { return _clicks; }
	            set { SetField(ref _clicks, value); }
	        }
	        private int _clicks;
	
	        [DataMember(Name = "opens")]
	        public int Opens
	        {
	            get { return _opens; }
	            set { SetField(ref _opens, value); }
	        }
	        private int _opens;
	
	        [DataMember(Name = "unique_opens")]
	        public int UniqueOpens
	        {
	            get { return _unique_opens; }
	            set { SetField(ref _unique_opens, value); }
	        }
	        private int _unique_opens;
    	}
}
