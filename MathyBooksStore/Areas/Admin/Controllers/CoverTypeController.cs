﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathyBooksStore.Areas.Admin.Controllers
{
    public class CoverTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
