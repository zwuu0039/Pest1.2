﻿using Pest1._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pest1._2.Controllers
{
    public class HomeController : Controller
    {
        private PestLocationEntities db = new PestLocationEntities();
        public ActionResult Index()
        {
            return View();
        }

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

        public ActionResult Location()
        {
            var pest = db.PestLocation.ToList();


            return View(pest);
        }
    }
}