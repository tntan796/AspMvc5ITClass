using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            Student st = new Student();
            st.Id = int.Parse(f[0]);
            st.Name = f.Get("Name");
            return View(st);
        }

        [HttpGet]
        public ActionResult Demo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Demo(FormCollection form)
        {
            return View();
        }
    }
}