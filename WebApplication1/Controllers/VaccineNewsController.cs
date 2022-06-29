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
    public class VaccineNewsController : ControllerBase
    {
        private readonly ILogger<VaccineNewsController> _logger10;
        private readonly VaccineNewsClient _vaccineNewsClient;

        public VaccineNewsController(ILogger<VaccineNewsController> logger10, VaccineNewsClient vaccineNewsClient)
        {
            _logger10 = logger10;
            _vaccineNewsClient = vaccineNewsClient;

        }

        [HttpGet("{page}")]
        public async Task<VaccineNews> GetVaccineNews([FromRoute] string page)
        {

            var vaccineNews = await _vaccineNewsClient.GetVaccineNews(page);
            return vaccineNews;
        }
    }
}
