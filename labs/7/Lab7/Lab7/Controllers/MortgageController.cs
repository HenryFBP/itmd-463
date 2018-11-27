using Lab7.Models;
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

            // Saving the results to a database.
            {
                MortgageLoggerSQL.TryCreateTables(); // Yes, I am too lazy to run this at the start of the program. Let's just do it here.

                MortgageLoggerSQL.Log(mortgageInfo, mortgageResult);
            }


            return View("IndexResult", mortgageResult);
        }

        [HttpGet]
        public ActionResult IndexResult(MortgageResult mortgageResult)
        {
            return View();
        }

    }
}