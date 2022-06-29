using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Clients
{
    public class CovidAustralian_and_Oceanian_countiesClient
    {
        private HttpClient _client7;
        private static string _address;
        private static string _apiKey;
        public CovidAustralian_and_Oceanian_countiesClient()
        {
            _address = Constants.adress;
            _apiKey = Constants.apiKey;

            _client7 = new HttpClient();
            _client7.BaseAddress = new Uri(_address);

        }
        public async Task<List<CovidAustralian_and_Oceanian_counties>> GetCovidAustralian_and_Oceanian_counties()
        {
            HttpClient _client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/npm-covid-data/australia"),
                Headers =
                {
                    {"X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com"},
                    { "X-RapidAPI-Key", "27444bf02dmshd9f9c06755ed955p1732fcjsne1985cdff6b7"},


                },
            };
            var responce = await _client.SendAsync(request);
            responce.EnsureSuccessStatusCode();
            var content = await responce.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<CovidAustralian_and_Oceanian_counties>>(content);
            return result;





        }
    }
}
