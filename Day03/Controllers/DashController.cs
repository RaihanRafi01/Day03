﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day03.Controllers
{
    public class DashController : Controller
    {
        // GET: Dash
        public ActionResult Index()
        {
            return View();
        }
    }
}