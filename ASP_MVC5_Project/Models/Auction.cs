using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_MVC5_Project.Models
{
    public class Auction
    {
        public long id { get; set; }

        public string Category { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public decimal StartPrice { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}