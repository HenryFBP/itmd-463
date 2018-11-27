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
        public ActionResult Index(double Cost, double Principle, double InterestRate, int DurationYears)
        {
            MortgageInfo mortgageInfo = new MortgageInfo(Cost, Principle, InterestRate, DurationYears);
            
            MortgageResult mortgageResult = new MortgageResult { MonthlyPayment = MortgageLib.MonthlyPayment(mortgageInfo) };

            return View("IndexResult", mortgageResult);
        }

        [HttpGet] 
        public ActionResult IndexResult(MortgageResult mortgageResult)
        {
            return View();
        }

    }
}