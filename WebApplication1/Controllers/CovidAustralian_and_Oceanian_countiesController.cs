using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Clients;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidAustralian_and_Oceanian_countiesController : ControllerBase
    {
        

            private readonly ILogger<CovidAustralian_and_Oceanian_countiesController> _logger7;
            private readonly CovidAustralian_and_Oceanian_countiesClient _covidAustralian_and_Oceanian_countiesClient;

            public CovidAustralian_and_Oceanian_countiesController(ILogger<CovidAustralian_and_Oceanian_countiesController> logger7, CovidAustralian_and_Oceanian_countiesClient covidAustralian_and_Oceanian_countiesClient)
            {
                _logger7 = logger7;
                _covidAustralian_and_Oceanian_countiesClient = covidAustralian_and_Oceanian_countiesClient;

            }

            [HttpGet]
            public async Task<List<CovidAustralian_and_Oceanian_counties>> GetCovidAustralian_and_Oceanian_counties()
            {

                var covidAustralian_and_Oceanian_counties = await _covidAustralian_and_Oceanian_countiesClient.GetCovidAustralian_and_Oceanian_counties();
                return covidAustralian_and_Oceanian_counties;
            }

        
    }
}
