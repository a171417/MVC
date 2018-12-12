using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class HoleController : Controller
    {
        // GET: Hole
        public ActionResult cust()
        {
            Customer cus = new Models.Customer();
            Employee emp = new Models.Employee();
            cus.CustomerName = "我是西红柿";
            emp.Name = "我是西红柿首富";
            
          

        }
    }
}