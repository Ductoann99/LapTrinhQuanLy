using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BDTBaithuchanh345.Controllers
{
    public class ThucHanhController : Controller
    {
        // GET: ThucHanh
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult About(string Masinhvien , string Hovaten)
        {
            ViewBag.Message =  Masinhvien + " " + Hovaten;

            return View();
        }
       
    }
}