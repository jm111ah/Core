using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CCore.Controllers
{
    public class CoreController : Controller
    {
        public IActionResult Core_1()
        {
            return View();
        }

        public IActionResult EF()
        {
            return View();
        }

        public IActionResult LINQ()
        {
            return View();
        }
    }
}