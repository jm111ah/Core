using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CCore.Controllers
{
    public class CharpController : Controller
    {
        public IActionResult Charp_1()
        {
            return View();
        }
    }
}