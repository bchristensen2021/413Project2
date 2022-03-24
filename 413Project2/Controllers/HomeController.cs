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
            //var timeslots = tsContext.TimeSlots.ToList();
            //return View(timeslots);
            var appointments = tsContext.TimeSlots.ToList();
            return View(appointments);
        }
        
        public IActionResult ScheduledTours()
        {
            return View();
        }

        //This is the get action
        [HttpGet]
        public IActionResult Form(int timeslotid)
        {

            ViewBag.TimeSlots = tsContext.TimeSlots.ToList();
          

            return View("Form");
        }

        //This is the post action
        [HttpPost]
        public IActionResult Form(AppointmentInfo ai, int timeslotid)
        {
            if (ModelState.IsValid)
            {
                ViewBag.TimeSlots = tsContext.TimeSlots.ToList();
                
                tsContext.Add(ai);
                
                tsContext.SaveChanges();         
              
                return View("Index");
            }
            else //if invalid
            {
                ViewBag.TimeSlots = tsContext.TimeSlots.ToList();

                return View();
            }

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //This function recieves the id of the user-selected record
        [HttpGet]
        public IActionResult Edit(int appid)
        {
            ViewBag.TimeSlots = tsContext.TimeSlots.ToList();

            var form = tsContext.AppointmentInfo.Single(x => x.AppId == appid);

            return View("Form", form);
        }

        //This function recieves the response of form
        [HttpPost]
        public IActionResult Edit(AppointmentInfo blah)
        {
            tsContext.Update(blah);
            tsContext.SaveChanges();
            return RedirectToAction("Signup");
        }

        //This function recieves the id of the user-selected record
        [HttpGet]
        public IActionResult Delete(int appointmentid)
        {
            var application = tsContext.AppointmentInfo.Single(x => x.AppId == appointmentid);

            return View(application);
        }

        //This function recieves the response of the user-selected button (cancel or delete)
        [HttpPost]
        public IActionResult Delete(AppointmentInfo ai)
        {
            tsContext.AppointmentInfo.Remove(ai);
            tsContext.SaveChanges();
            return RedirectToAction("Signup");
        }
    }

    
}
