using Student.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Student.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]

        public ActionResult Index(Student.Models.Student students)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("home");
            }

            return View(students);
        }
        public ActionResult logout()
        {
            return View();
        }

        public ActionResult home()
        {
            return View();
        }
    }
}