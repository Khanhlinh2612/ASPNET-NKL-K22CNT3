using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lession02.NKL.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products ~ http://localhost:port/products
        public ActionResult Index()
        {
            ViewBag.name = "Linh-2210900035";
            return View();
        }

        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();  
        }

        public string GetName()
        {

            return "Linh - 2210900035";
        }

        public JsonResult ListName()
        {
            string[] names = { "hung", "dung", "sang" };
            return Json(names, JsonRequestBehavior.AllowGet);
        }
    }
}