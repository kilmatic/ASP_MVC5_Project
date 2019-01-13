﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_MVC5_Project.Models
{
    public class Bid
    {
        public long Id { get; set; }
        public long AuctionId { get; set; }

        [Required]
        public DateTime TimeStamp { get; set; }

        public string Username { get; set; }

        [Range(1, double.MaxValue)]
        public decimal Amount { get; set; }

        public Bid()
        {
            TimeStamp = DateTime.Now;
        }
    }
}