using classwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classwork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult Submit()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Create(student st)
        {
            ViewBag.Message = "Your contact page.";
            /*ViewBag.Id = from["Id"];
            ViewBag.Name = from["Name"];
            ViewBag.Dob = from["Dob"];*/

           /* ViewBag.Id = Request["Id"];
            ViewBag.Name = Request["Name"];
            ViewBag.Dob = Request["Dob"];*/
           if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(st);
        }
    }
}