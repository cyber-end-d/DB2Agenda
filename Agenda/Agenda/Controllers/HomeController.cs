using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "FIE - Final Base de Datos II";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Donis, Marina";

            return View();
        }
    }
}