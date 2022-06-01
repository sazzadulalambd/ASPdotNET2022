using classwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace classwork.Controllers
{
    public class ProductController : Controller
    {

        // GET: Product
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product()
                    { 
                    Id = (i + 1),
                    Name = "Product " + (i + 1),
                    Price = 599
                    }
                );
            }
            return View(products);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product Pro)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(Pro);
        }
    }
}