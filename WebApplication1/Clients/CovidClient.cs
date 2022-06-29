using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WebApplication1.Models;


namespace WebApplication1.Clients
{
   

    public class CovidClient
    {
        
       private  HttpClient _client;
       private static  string _address;
       private static  string _apiKey;

        public CovidClient()
        {
            _address = Constants.adress;
            _apiKey = Constants.apiKey;

            _client = new HttpClient();
            _client.BaseAddress = new Uri(_address);

        }

        public async Task<List<WorldData>> GetCovidWorld(string contryname, string iso )
        {
            HttpClient _client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/npm-covid-data/country-report-iso-based/{contryname}/{iso}"),
                Headers =
                {
                    {"X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com"},
                    { "X-RapidAPI-Key", "27444bf02dmshd9f9c06755ed955p1732fcjsne1985cdff6b7"},


                },
            };
            var responce = await _client.SendAsync(request);
            responce.EnsureSuccessStatusCode();
            var content = await responce.Content.ReadAsStringAsync();
            
            var result = JsonConvert.DeserializeObject<List<WorldData>>(content); 
            return result;

            



        }
        
        




        
    }
}
