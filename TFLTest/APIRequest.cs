using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TFLTest
{
    public class APIRequest
    {
        private static string mbrApplicationID = "";
        private static string mbrApplicationKey = "";

        static HttpClient client = new HttpClient();
        public static async Task<string> GetRoadStatus(string search)
        {
            string path = "https://api.tfl.gov.uk/Road/" + search + "?app_key=" + mbrApplicationKey + "&app_id=" + mbrApplicationID;
            string output = $"{search} is not a valid road";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                List<RoadDescription> RequestContent = new List<RoadDescription>();
                RequestContent = await response.Content.ReadAsAsync<List<RoadDescription>>();
                RoadDescription Result = RequestContent.FirstOrDefault();
                output = $"The status of the {search} is as follows" + Environment.NewLine + $"Road Status is {Result.statusSeverity}" + Environment.NewLine + $"Road Status Description is {Result.statusSeverityDescription}";
            }
            return output;
        }

    }
}
