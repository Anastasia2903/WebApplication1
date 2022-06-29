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
    public class CovidEuropeanController : ControllerBase
    {
        private readonly ILogger<CovidEuropeanController> _logger4;
        private readonly CovidEuropeanClient _covidEuropeanClient;

        public CovidEuropeanController(ILogger<CovidEuropeanController> logger4, CovidEuropeanClient covidEuropeanClient)
        {
            _logger4 = logger4;
            _covidEuropeanClient = covidEuropeanClient;

        }
        [HttpGet]
        public async Task<List<CovidEuropean>> GetCovidEuropean()
        {
            var covidEuropeans = await _covidEuropeanClient.GetCovidEuropean();
            return covidEuropeans;
        }
    }
}
