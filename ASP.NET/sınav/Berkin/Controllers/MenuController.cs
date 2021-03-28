using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Berkin.Models;

namespace Berkin.Controllers
{
    public class MenuController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ViewResult Index(Menu menu)
        {
            Repository.AddMenu(menu);
            return View();
        }
    }
}
