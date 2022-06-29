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
    public class CovidCountryController : ControllerBase
    {
        private readonly ILogger<CovidCountryController> _logger8;
        private readonly CovidCountryClient _covidCountryClient;

        public CovidCountryController(ILogger<CovidCountryController> logger8, CovidCountryClient covidCountryClient)
        {
            _logger8 = logger8;
            _covidCountryClient = covidCountryClient;

        }

        [HttpGet("{iso}")]
        public async Task<List<CovidCountry>> GetCovidWorld([FromRoute] string iso)
        {

            var covidcountry = await _covidCountryClient.GetCovidContry(iso);
            return covidcountry;
        }

    }
}
