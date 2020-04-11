using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tuan1_BT2.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(double a = 0, double b = 0, String pt = "+")
        {
            ViewBag.a = a;
            ViewBag.b = b;
            switch (pt)
            {
                case "+": ViewBag.KQ = a + b; break;
                case "-": ViewBag.KQ = a - b; break;
                case "*": ViewBag.KQ = a * b; break;
                case "/":
                if (b == 0) ViewBag.KQ = "Không chia được cho 0";
                else ViewBag.KQ = a / b; break;
            }
            return View();
        }
    }
}