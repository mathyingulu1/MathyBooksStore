using MathysBooks.DataAccess.Repository.IRepository;
using MathysBooks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
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
