using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Weather_Report_Limassol
{
    public class WeatherInfo
    {     

        public async Task<JObject> GetInformation()
        {
            string url = "https://weather.visualcrossing.com/VisualCrossingWebServices/rest/services/weatherdata/forecast?locations=limassol&aggregateHours=24&forecastDays=3&unitGroup=metric&shortColumnNames=false&contentType=json&iconSet=icons1&key=3KQTHQWBFGAD4PQY32S4592N3";

            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url);
            var result = response.Content.ReadAsStringAsync().Result;
            var finalJson = JObject.Parse(result);

            return finalJson;
 

        }

        public string Temperature { get; private set; }
        public string MaxTemperature { get; private set; }
        public string Conditions { get; private set; }
        public string Humidity { get; private set; }
        public string Date { get; private set; }
        public string Icon { get; private set; }

        public WeatherInfo(int jsonIndex)
        {
            Task<JObject> weatherGet = GetInformation();
            JObject weatherData = weatherGet.Result;

            this.Temperature = weatherData["locations"]["limassol"]["values"][jsonIndex]["temp"].ToString();
            this.MaxTemperature = weatherData["locations"]["limassol"]["values"][jsonIndex]["maxt"].ToString();
            this.Conditions = weatherData["locations"]["limassol"]["values"][jsonIndex]["conditions"].ToString().ToLower();
            this.Humidity = weatherData["locations"]["limassol"]["values"][jsonIndex]["humidity"].ToString();
            this.Date = weatherData["locations"]["limassol"]["values"][jsonIndex]["datetimeStr"].ToString();
            this.Icon = weatherData["locations"]["limassol"]["values"][jsonIndex]["icon"].ToString();
        }

    }
}
