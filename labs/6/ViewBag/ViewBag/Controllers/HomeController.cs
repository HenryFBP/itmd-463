using System;
using System.Web.Mvc;

namespace ViewBagLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.FirstName = "Henry";
            ViewBag.LastName = "Post";
            ViewBag.Course = "ITMD463";

            ViewBag.Time = DateTime.Now.ToString();

            return View();
        }
    }
}