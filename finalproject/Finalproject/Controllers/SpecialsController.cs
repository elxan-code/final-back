﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class SpecialsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}