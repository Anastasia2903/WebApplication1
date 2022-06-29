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
    public class HealthNewsController : ControllerBase
    {
        private readonly ILogger<HealthNewsController> _logger11;
        private readonly HealthNewsClient _healthNewsClient;

        public HealthNewsController(ILogger<HealthNewsController> logger11, HealthNewsClient healthNewsClient)
        {
            _logger11 = logger11;
            _healthNewsClient = healthNewsClient;

        }

        [HttpGet("{page}")]
        public async Task<HealthNews> GetHealthNews([FromRoute] string page)
        {

            var healthNews = await _healthNewsClient.GetHealthNews(page);
            return healthNews;
        }
    }
}
