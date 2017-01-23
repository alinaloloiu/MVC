using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [ActionName ("about")]
        public ActionResult SomeMethodName()
        {
            return View();
        }

        [HttpGet]
        public ActionResult VerbTest()
        {
            return Content("Hello");
        }

        [ActionName("authorize")]
        [Authorize(Roles="Admin")]
        public ActionResult ThisMethodNeedsAuthorization()
        {
            return Content("Hello");
        }

        public double Calc()
        {
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach (int x in list)
                sum += x;
            return sum;
        }
    }
}