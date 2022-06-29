using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CovidCountry
    {
        public string Name { get; set; }
        public string Province { get; set; }
        public string iso { get; set; }
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Deaths { get; set; }
        public int Active { get; set; }
        public double Fatality_rate { get; set; }
    }
}
