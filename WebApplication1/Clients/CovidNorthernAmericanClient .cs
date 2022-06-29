using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Clients
{
    public class CovidNorthernAmericanClient
    {
        private HttpClient _client5;
        private static string _address;
        private static string _apiKey;

        public CovidNorthernAmericanClient()
        {
            _address = Constants.adress;
            _apiKey = Constants.apiKey;

            _client5 = new HttpClient();
            _client5.BaseAddress = new Uri(_address);

        }
        public async Task<List<CovidNorthernAmerican>> GetCovidNorthernAmerican()
        {
            HttpClient _client5 = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/npm-covid-data/northamerica"),
                Headers =
                {
                    {"X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com"},
                    { "X-RapidAPI-Key", "27444bf02dmshd9f9c06755ed955p1732fcjsne1985cdff6b7"},


                },
            };
            var responce = await _client5.SendAsync(request);
            responce.EnsureSuccessStatusCode();
            var content = await responce.Content.ReadAsStringAsync();

            var covidNorthernAmerican = JsonConvert.DeserializeObject<List<CovidNorthernAmerican>> (content);
            return covidNorthernAmerican;





        }
    }

}
