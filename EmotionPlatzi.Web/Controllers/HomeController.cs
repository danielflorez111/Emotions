using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmotionPlatzi.Web.Models;

namespace EmotionPlatzi.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WelcomeMessage = "Hola Medellin";
            ViewBag.ValorEntero = 9;
            return View();
        }

        public ActionResult IndexAlt()
        {
            var modelo = new Home();
            modelo.WelcomeMessage = "Hola Pereira";
            return View(modelo);
        }
    }
}