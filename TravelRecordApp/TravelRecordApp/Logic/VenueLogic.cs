using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Helpers;
using TravelRecordApp.Model;

namespace TravelRecordApp.Logic
{
    public class VenueLogic
    {
        public static async Task<List<Result>> GetVenues(double latitude, double longitude)
        {
            List<Result> venues = new List<Result>();

            var url = VenueRoot.GenerateUrl(latitude, longitude);

            var client = new RestClient(url);

            var request = new RestRequest();

            request.Method = Method.Get;

            request.AddHeader("Accept", "application/json");

            request.AddHeader("Authorization", Constants.HEADER);

            RestResponse response = await client.ExecuteAsync(request);

            var json = response.Content.ToString();



            var venueRoot = JsonConvert.DeserializeObject<Venue>(json);

            venues = venueRoot.results as List<Result>;





            return venues;
            /*List<Venue> venues = new List<Venue>();

            var url = Venue.GenerateURL(latitude, longitude);

            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

            }

                return venues;*/
        }
    }
}
