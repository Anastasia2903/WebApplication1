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
    public class TreatmentsController : ControllerBase
    {
        private readonly ILogger<TreatmentsController> _logger12;
        private readonly TreatmentsClient _treatmentsClient;

        public TreatmentsController(ILogger<TreatmentsController> logger12, TreatmentsClient treatmentsClient)
        {
            _logger12 = logger12;
            _treatmentsClient = treatmentsClient;

        }


        [HttpGet]
        public async Task<List<Treatments>> GetTreatments()
        {
            var treatments = await _treatmentsClient.GetTreatments();
            return treatments;
        }
    }
}
