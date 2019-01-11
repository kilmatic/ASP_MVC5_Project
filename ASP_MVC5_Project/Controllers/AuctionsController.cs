using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP_MVC5_Project.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auctions
        public ActionResult Index()
        {
            var auctions = new[]
            {
                new Models.Auction()
                {
                    Title = "Example Auction #1",
                    Description = "This is an example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurrentPrice = 0,
                },
                new Models.Auction()
                {
                    Title = "Example Auction #2",
                    Description = "This is an example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 1.00m,
                    CurrentPrice = 30m,
                },
                new Models.Auction()
                {
                    Title = "Example Auction #3",
                    Description = "This is an example Auction",
                    StartTime = DateTime.Now,
                    EndTime = DateTime.Now.AddDays(7),
                    StartPrice = 10.00m,
                    CurrentPrice = 24m,
                }
            };

            return View(auctions);
        }

        public ActionResult TempDataDemo()
        {
            TempData["SuccessMessage"] = "The action succeeded!";

            return RedirectToAction("Index");
        }

        public ActionResult Auction(long id)
        {
            var auction = new ASP_MVC5_Project.Models.Auction()
            {
                Title = "Example Auction",
                Description = "This is an example Auction",
                StartTime = DateTime.Now,
                EndTime = DateTime.Now.AddDays(7),
                StartPrice = 1.00m,
                CurrentPrice = 0,
            };

            return View(auction);
        }
        public ActionResult Create([Bind(Exclude = "CurrentPrice")]Models.Auction auction)
        {
            var categoryList = new SelectList(new [] { "Automotive", "Electronics", "Games", "Home" });
            ViewBag.CategoryList = categoryList;
            return View();
        }
    }
}