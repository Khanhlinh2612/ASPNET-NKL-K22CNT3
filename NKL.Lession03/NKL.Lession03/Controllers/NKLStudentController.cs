using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NKL.Lession03.Controllers
{
    public class NKLStudentController : Controller
    {
        // GET: NKLStudent
        public ActionResult Index()
        {
            //Du lieu tu view Data
            ViewData["msg"] = "View Data - Nguyen Khanh Linh";
            ViewData["time"] = DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy tt");    
            return View();
        }

        public ActionResult StuudentList()
        {
            //sd view bag
            //luu tru gia tri don
            ViewBag.titleName = "Danh sach hoc vien - Nguyen Khanh Linh";

            //Gia tri la mot tap hop
            string[] names = { "Linh","phuc","nam"};
            ViewBag.list=names;

            //gia tri la mot doi tuong
            var ojb = new
            {
                ID = 100,
                Name = "Linh",
                Age = 19
            };
            ViewBag.student = ojb;
            return View();
        }

        public ActionResult Insert()
        {
            return View("AddStudent");
        }
    }
}