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
    public class CovidNewsController : ControllerBase
    {
        private readonly ILogger<CovidNewsController> _logger9;
        private readonly CovidNewsClient _covidNewsClient;

        public CovidNewsController(ILogger<CovidNewsController> logger9, CovidNewsClient covidNewsClient)
        {
            _logger9 = logger9;
            _covidNewsClient = covidNewsClient;

        }

        //[HttpGet]
        //public async Task<CovidNews> GetCovidNews([FromQueryAttribute] CovidNewsParameter parameter)
        //{

        //    var covidNews = await _covidNewsClient.GetCovidNews(parameter.page);
        //    return covidNews;
        //}
        [HttpGet("{page}")]
        public async Task<CovidNews> GetCovidNews([FromRoute] string page)
        {

                var covidNews = await _covidNewsClient.GetCovidNews(page);
               return covidNews;
        }
    }
}
