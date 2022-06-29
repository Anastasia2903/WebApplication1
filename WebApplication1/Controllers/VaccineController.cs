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
    
    public class VaccineController : ControllerBase
    {
        private readonly ILogger<VaccineController> _logger1;
        private readonly VaccineClient _vaccineClient1;

        public VaccineController(ILogger<VaccineController> logger1, VaccineClient vaccineClient)
        {
            _logger1 = logger1;
            _vaccineClient1 = vaccineClient;

        }


        [HttpGet]
        public async Task<List<VaccineWorld>> GetVaccinedWorld()
        {
            var vaccineword = await _vaccineClient1.GetVaccineWorld();
            return vaccineword;
        }
    }
}
