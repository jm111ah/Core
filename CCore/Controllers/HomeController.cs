using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CCore.Models;

namespace CCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Charp()
        {
            return View();
        }

        public IActionResult Core()
        {
            return View();
        }

        public IActionResult JavaScript()
        {
            return View();
        }
    }
}
