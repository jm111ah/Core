using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CCore.Models;
using CCore.Lib;

namespace CCore.Controllers
{
    public class HomeController : Controller
    {
        protected Login login = new Login();
        protected string Result = string.Empty;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User info)
        {
            Result = login.LoginCheck(info.Email , info.PW);

            if (Result == "True")
            {

            }
            

            return View();
        }


        public IActionResult Sign()
        {
            return View();
        }

    }
}
