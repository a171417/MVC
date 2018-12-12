using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string GetString()
        {
            return "你好";
        }
        public Models.Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerName = "adc";
            ct.Address = "ss";
            return ct;
        }
        public ActionResult MyView()
        {
            string greeting;
            DateTime dt = DateTime.Now;
            int hour = dt.Hour;
            if (hour < 12)
            {
                greeting = "早上好";
            }
            else
            {
                greeting = "下午好";
            }
            //ViewData["greeting"] = greeting;
            ViewBag.Greeting = greeting;

            Employee emp = new Employee();
            emp.Name = "李四";
            emp.Salary = 2000;
            //ViewData["Employee"] = emp;
            ViewBag.Employee = emp;
           /* return View("MyView",emp)   */                                                                ;

            EmployeeViewMode vmEmp = new EmployeeViewMode();
            vmEmp.EmployeeName = emp.Name;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 1000)
            {
                vmEmp.SalarGrade = "土豪";
            }
            else
            {
                vmEmp.SalarGrade = "屌丝";
            }
            vmEmp.UserName = "admin";
            return View("MyView", vmEmp);

        }
    
    }
}