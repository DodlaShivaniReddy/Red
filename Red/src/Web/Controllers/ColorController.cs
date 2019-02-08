using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class ColorController : Controller
    {
        public IActionResult ShowText()
        {
            return Content("Welcome Welcome Welcome!!!");
        }
        public IActionResult ShowJSON()
        {
            return Json(new { name = "favorite color", quote = "Red is my favorite color." });
        }
        public IActionResult ShowHTML()
        {
            var h = "<!DOCTYPE html><html><body>Have a colorful life.</body></html>";
            return Content(h, "text/html");
        }

        public IActionResult ShowView()
        {
            return View();
        }
    }
}