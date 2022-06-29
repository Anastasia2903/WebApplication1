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
    
    public class CovidAfricaController : ControllerBase
    {

        private readonly ILogger<CovidAfricaController> _logger3;
        private readonly CovidAfricanClient _covidAfricanClient;
        public CovidAfricaController(ILogger<CovidAfricaController> logger3, CovidAfricanClient covidAfricanClient)
        {
            _logger3 = logger3;
            _covidAfricanClient = covidAfricanClient;

        }
        [HttpGet]
        public async Task<List<CovidAfrica>> GetCovidAfrica()
        {
            var covidafrika = await _covidAfricanClient.GetCovidAfrica();
            return covidafrika;
        }

    }
}
