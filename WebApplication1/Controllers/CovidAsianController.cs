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
    public class CovidAsianController : ControllerBase
    {
        

            private readonly ILogger<CovidAsianController> _logger2;
            private readonly CovidAsianClient _covidAsianClient;
            public CovidAsianController(ILogger<CovidAsianController> logger2, CovidAsianClient covidAsianClient)
            {
                _logger2 = logger2;
                _covidAsianClient = covidAsianClient;

            }
            [HttpGet]
            public async Task<List<CovidAsian>> GetCovidAsian()
            {
                var covidasian = await _covidAsianClient.GetCovidAsian();
                return covidasian;
            }
        
    }
}
