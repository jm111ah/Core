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
        protected Sign sign = new Sign();
        protected User user = new User();
        protected bool Result = false;


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
            if (ModelState.IsValid)
            {
                Result = sign.LoginCheck(info);


            }

            return View();
        }

        public IActionResult Sign()
        {
            return View();
        }

        [HttpPost]
      public  IActionResult Sign(User info)
        {
            if (ModelState.IsValid)
            {
                Result = sign.SignUp(info);
            }

            return View();
        }

       public IActionResult Community()
        {
            return View();
        }

        public IActionResult QA()
        {
            return View();
        }



    }
}
