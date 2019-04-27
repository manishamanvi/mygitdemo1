using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mugitdemo.Controllers
{
    public class HomeController : Controller
    {
        //thi is devv
        //ghghghg
        //this is modified field
        public ActionResult Index()
        {
            return View();
        }
        //this
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}