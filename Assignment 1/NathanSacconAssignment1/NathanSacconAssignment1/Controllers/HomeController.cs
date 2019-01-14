using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NathanSacconAssignment1.Models;

namespace NathanSacconAssignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Home/Show
        public ViewResult Show()
        {
            return View("Show", new Contact());
        }

        public IActionResult Set(string first, string last)
        {
            Contact.WriteContact(first, last);
            ViewBag.First = first;
            ViewBag.Last = last;
            return View();
        }
    }
}