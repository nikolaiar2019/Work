using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test_2019.Models;

namespace Test_2019.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Login()
        {
            return View("login");
        }

       
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Login");
        }
    }
}
