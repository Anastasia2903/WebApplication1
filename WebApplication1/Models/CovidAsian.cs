﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CovidAsian
    {
        public string Country { get; set; }
        public string Continent { get; set; }
        public string ThreeLetterSymbol { get; set; }
        public double Infection_Risk { get; set; }
        public int TotalCases { get; set; }
        public int NewCases { get; set; }
        public int TotalDeaths { get; set; }
        public int NewDeaths { get; set; }
        public int TotalRecovered { get; set; }
        public int NewRecovered { get; set; }
        public int ActiveCases { get; set; }
        public int Serious_Critical { get; set; }
    }
}
