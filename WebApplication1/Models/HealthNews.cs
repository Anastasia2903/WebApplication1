using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class HealthNews
    {
        
       
        public _News[] news { get; set; }
        

        public class _News
        {
            public string news_id { get; set; }
            public string title { get; set; }
            public string link { get; set; }
            public string urlToImage { get; set; }
            public string imageInLocalStorage { get; set; }
            public string imageFileName { get; set; }
            public DateTime pubDate { get; set; }
            public string content { get; set; }
            public string reference { get; set; }
        }
    }
}
