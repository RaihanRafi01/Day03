﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day03.Controllers
{
    public class PageController : Controller
    {
        // GET: Page
        public ActionResult Index()
        {
            return View();
            // jyjfhkvhjnm SS
        }

        public ActionResult Submit()
        {
            TempData["msg"] = "Login Successful";
            return RedirectToAction("Index", "Dash");
        }

        public ActionResult SignUp()
        {
            return View();
        }
    }
}