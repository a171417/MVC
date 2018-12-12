using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class New1212Controller : Controller
    {
        // GET: New1212
        public ActionResult GetView()
        {//生成列表视图 模型
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            //生成业务访问对象
            EmployeeBusinessLayer empBai = new EmployeeBusinessLayer();

            List<Employee> employees = empBai.GetEmployees();

            List<EmployeeViewMode> empViewModels = new List<EmployeeViewMode>();

            foreach (Employee emp in employees)
            {
                EmployeeViewMode empViewModel = new EmployeeViewMode();
                empViewModel.EmployeeName = emp.Name;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 10000)
                {
                    empViewModel.SalarGrade = "土豪";
                }
                else
                {
                    empViewModel.SalarGrade = "钓丝";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.UserName = "admin";
            return View("MyView", employeeListViewModel);
        }
    }
}