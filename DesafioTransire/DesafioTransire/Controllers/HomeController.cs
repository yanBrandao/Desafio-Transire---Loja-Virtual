using DesafioTransire.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DesafioTransire.Controllers
{
    public class HomeController : Controller
    {
        private ProductsGH _db;

        public ActionResult Index()
        {
            _db = new ProductsGH();
            
            //return View(_db.Products.ToList());
            return Content("Teste GearHost");
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
    }
}