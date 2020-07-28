using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Linka.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult TermsConditions()
        {
            return View();
        }
    }
}