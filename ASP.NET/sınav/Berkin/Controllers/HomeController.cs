using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berkin.Models;

namespace Berkin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var menu = new Menu();
            menu.id = 1;
            menu.Name = "DENEME";
            menu.Price = 2.6; 
            return View();
        }

    }
}
