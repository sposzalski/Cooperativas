﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quilmes.Cooperativas.Portal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contacto()
        {           
            return View();
        }

        public ActionResult Noticias()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}