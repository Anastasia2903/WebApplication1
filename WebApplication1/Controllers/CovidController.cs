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
    [ApiController]
    [Route("[controller]")]
    public class CovidController : ControllerBase
    {


        private readonly ILogger<CovidController> _logger;
        private readonly CovidClient _covidClient;

        public CovidController(ILogger<CovidController> logger, CovidClient covidClient)
        {
            _logger = logger;
            _covidClient = covidClient;

        }

        [HttpGet("{countryname}/{iso}")]
        public async Task<List<WorldData>> GetCovidWorld([FromRoute] string countryname, string iso)
        {

            var covidword = await _covidClient.GetCovidWorld(countryname, iso);
            return covidword;
        }
        //[HttpGet("{countryname}/{iso}")]
        //public async Task<List<WorldData>> GetCovidWorld([FromRoute] string countryname, string iso)
        //{

        //    var _covidword = await _covidClient.GetCovidWorld(countryname, iso);
        //    return _covidword;
        //}
    } 
}

