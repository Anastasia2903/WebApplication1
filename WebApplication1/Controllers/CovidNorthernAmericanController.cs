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
    public class CovidNorthernAmericanController : ControllerBase
    {
        private readonly ILogger<CovidNorthernAmericanController> _logger5;
        private readonly CovidNorthernAmericanClient _covidNorthernAmericanClient;
        public CovidNorthernAmericanController(ILogger<CovidNorthernAmericanController> logger5, CovidNorthernAmericanClient covidNorthernAmericanClient)
        {
            _logger5 = logger5;
            _covidNorthernAmericanClient = covidNorthernAmericanClient;

        }
        [HttpGet]
        public async Task<List<CovidNorthernAmerican>> GetCovidNorthernAmerican()
        {
            var covidNorthernAmerican = await _covidNorthernAmericanClient.GetCovidNorthernAmerican();
            return covidNorthernAmerican;
        }
    }
}
