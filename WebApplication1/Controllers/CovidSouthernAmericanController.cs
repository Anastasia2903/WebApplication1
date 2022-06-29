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
    public class CovidSouthernAmericanController : ControllerBase
    {
        private readonly ILogger<CovidSouthernAmericanController> _logger6;
        private readonly CovidSouthernAmericanClient _covidSouthernAmericanClient;
        public CovidSouthernAmericanController(ILogger<CovidSouthernAmericanController> logger6, CovidSouthernAmericanClient covidSouthernAmericanClient)
        {
            _logger6 = logger6;
            _covidSouthernAmericanClient = covidSouthernAmericanClient;

        }
        [HttpGet]
        public async Task<List<CovidSouthernAmerican>> GetCovidSouthernAmerican()
        {
            var covidSouthernAmerican = await _covidSouthernAmericanClient.GetCovidSouthernAmerican();
            return covidSouthernAmerican;
        }
    }
}
