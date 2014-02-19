using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qualtech.Models;

namespace Qualtech.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
         
                ViewBag.Message = "Du surfar med: "+ Request.Browser.Browser;

                return View("Index");
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
