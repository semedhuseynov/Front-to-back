﻿using System;
using Microsoft.AspNetCore.Mvc;

namespace FrontToBack.Controllers
{
	public class AboutController : Controller
	{
        public IActionResult Index()
        {
            return View();
        }
    }
}

