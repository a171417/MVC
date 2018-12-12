using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HoloController : Controller
    {
        // GET: Holo
        public ActionResult Customer()
        {
            Customer c = new Customer();
            c.CustomerName = "我";
            c.Address = "丰叶新苑";
            ViewBag.Customer = c;
            return View(c);
        }

    }
}