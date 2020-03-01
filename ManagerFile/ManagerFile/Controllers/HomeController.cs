using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ManagerFile.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagerFile.Controllers
{
    public sealed class HomeController : Controller
    {
        public IActionResult Index(string node = null)
        {
            return View();
        }

        public IActionResult Vue(string node = null)
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}