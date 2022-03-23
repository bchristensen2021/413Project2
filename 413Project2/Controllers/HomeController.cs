using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using _413Project2.Models;
using Microsoft.EntityFrameworkCore;

namespace _413Project2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private ToursDbContext tsContext { get; set; }

        public HomeController(ToursDbContext someName)
        {
            tsContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Signup()
        {
            var timeslots = tsContext.TimeSlots.ToList();
            return View();
        }
        
        public IActionResult ScheduledTours()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View("Form");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
