﻿using System;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SendGridStats.DataModel;
using System.Diagnostics;

namespace SendGridStats.Api
{
	public class SendGridApi
	{
		private const string SendGridApiBase = "https://api.sendgrid.com/api/";

		private string SendGridUsername = "";
		private string SendGridPassword = "";
		
		public SendGridApi(string username, string password)
		{
			SendGridUsername = username;
			SendGridPassword = password;
		}
		
		// days must be an integer greater than 0 and less than 1096, it represents 
		// the number of days in the past to include statistics (Includes today)
		
		// aggregate is either 0 or 1, where a value of 1 indicates you are interested in all-time totals
		
		// Documentation: https://sendgrid.com/docs/API_Reference/Web_API/Statistics/index.html
		public async Task<ObservableCollection<EmailStats>> GetStats(uint days = 1, uint aggregate = 0)
		{
			if (days < 1)
				throw new ArgumentException("The days argument must be larger than 0.", "days");
			if (days > 1095)
				throw new ArgumentException("The days argument must be less than 1096.", "days");

			var httpClient = new HttpClient();
			var response = await httpClient.GetAsync(
				new Uri(String.Format("{0}stats.get.json?api_user={1}&api_key={2}&date=1&days={3}&aggregate={4}", 
					SendGridApiBase, SendGridUsername, SendGridPassword, days, aggregate)));
            		
            		string responseBody = await response.Content.ReadAsStringAsync();
            		
            		if (aggregate == 1)
                		responseBody = "[" + responseBody + "]";
            		
            		return  JsonConvert.DeserializeObject<ObservableCollection<EmailStats>>(responseBody);
		}
	}
}
