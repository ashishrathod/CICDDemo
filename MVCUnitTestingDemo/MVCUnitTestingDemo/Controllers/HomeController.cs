using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUnitTestingDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //test
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public string GetEmployeeName(int empId)
        {
            string name;
            if (empId == 1)
            {
                name = "Jignesh";
            }
            else if (empId == 2)
            {
                name = "Rakesh";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }  

    }
}
