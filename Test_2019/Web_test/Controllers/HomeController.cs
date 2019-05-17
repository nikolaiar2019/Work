using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_test.Models;

namespace Web_test.Controllers
{
    public class HomeController : Controller
    {

       
        public IActionResult Index()
        {
            
            return this.View("Index");
           // new CheckUser();
        }


       
       [HttpGet]
       public IActionResult SignIn()
       {
           
          //  return RedirectToAction("./SignIn");
          return this.View("./SignIn");
       }


    }
}
