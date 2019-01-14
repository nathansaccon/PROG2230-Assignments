using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcTermLifeNathanSaccon.Models;

namespace MvcTermLifeNathanSaccon.Contollers
{
    public class HomeController : Controller
    {
        //GET: /HOME/INDEX
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Person p, Policy pol)
        {
            if (ModelState.IsValid)
            {
                decimal premium = Rate.MonthlyPremium(p.Age.Value, pol.Amount.Value);
                ViewBag.amount = String.Format("{0:C}", pol.Amount);
                ViewBag.premium = String.Format("{0:C}", premium);
                return View("Quotes", p);
            } else
            {
                return View();
            }
        }
    }
}