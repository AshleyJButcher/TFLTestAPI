using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TFLTest.Models;

namespace TFLTest
{
    public class APIRequest
    {
        private static string mbrApplicationID = "";
        private static string mbrApplicationKey = "";
        private static string URL = "https://api.tfl.gov.uk/Road/";

        static HttpClient client = new HttpClient();
        public static async Task<string> GetRoadStatus(string search)
        {
            string fullURL = $"{URL}{search}?app_key={mbrApplicationKey}&app_id={mbrApplicationID}";
            string output = $"{search} is not a valid road";
            HttpResponseMessage response = await client.GetAsync(fullURL);
            if (response.IsSuccessStatusCode)
            {
                List<RoadCorridor>  RequestContent = await response.Content.ReadAsAsync<List<RoadCorridor>>();
                RoadCorridor Result = RequestContent.FirstOrDefault();
                output = $"The status of the {search} is as follows" + Environment.NewLine + $"Road Status is {Result.StatusSeverity}" + Environment.NewLine + $"Road Status Description is {Result.StatusSeverityDescription}";
            }
            return output;
        }

    }
}



