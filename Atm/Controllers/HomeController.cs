using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Atm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [ActionName("about-the-Atm")]//user search this but system will take to About 
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About"); //here comes
        }
        [Route("Home/contact")]
        public ActionResult Contact()
        {
            ViewBag.Message = "HAving trouble send  us a Message";
            return View();
        }
        [HttpPost]
        public ActionResult Contact(String message)
        {
            ViewBag.Message = "thanks for sending message";
            return View();
        }
        public ActionResult coding()
        {
            return View(/*if you pass a string here of name  about your page as a argument then this go to that one page*/ );
        }
        public ActionResult Serial(String  letterCase)
        {
            var serial = "ASPADHGDCHSBDBDH";
            if (letterCase == "lower")
            {
                return Content(serial.ToLower());

            }
            return Content(serial);

        }
    }
}