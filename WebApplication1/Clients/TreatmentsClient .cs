using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Clients
{
    public class TreatmentsClient
    {
        private HttpClient _client12;
        private static string _address;
        private static string _apiKey;

        public TreatmentsClient()
        {
            _address = Constants.adress;
            _apiKey = Constants.apiKey;

            _client12 = new HttpClient();
            _client12.BaseAddress = new Uri(_address);

        }
        public async Task<List<Treatments>> GetTreatments()
        {
            HttpClient _client12 = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com/api/vaccines/get-all-treatment"),
                Headers =
                {
                    {"X-RapidAPI-Host", "vaccovid-coronavirus-vaccine-and-treatment-tracker.p.rapidapi.com"},
                    { "X-RapidAPI-Key", "27444bf02dmshd9f9c06755ed955p1732fcjsne1985cdff6b7"},


                },
            };
            var responce = await _client12.SendAsync(request);
            responce.EnsureSuccessStatusCode();
            var content = await responce.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<List<Treatments>>(content);
            return result;





        }
    }
}
