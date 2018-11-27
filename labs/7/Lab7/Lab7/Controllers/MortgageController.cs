using Lab7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7.Controllers
{
    public class MortgageController : Controller
    {
        // GET: Mortgage
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(float cost, float principle, float interestRate, float durationYears, float monthlyPayment)
        {
            MortgageResult mortgageResult = new MortgageResult();

            return View("IndexResult", mortgageResult);
        }

        [HttpGet] 
        public ActionResult IndexResult(MortgageResult mortgageResult)
        {
            return View();
        }

    }
}