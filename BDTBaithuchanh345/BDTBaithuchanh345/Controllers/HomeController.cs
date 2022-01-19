using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDTBaithuchanh345.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "helooo.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "heloooooooooo.";

            return View();
        }
    }
}