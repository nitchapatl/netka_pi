using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using netka_pi.Models;

namespace netka_pi.Controllers
{
    public class PIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add_PI()
        {
            return View();
        }
    }
}