﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
       public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.Name = "zhangsan";
            emp.Salary = 14000;
            employees.Add(emp);

            emp = new Employee();
            emp.Name = "zhu";
            emp.Salary = 15000;
            employees.Add(emp);

            return employees;

        }
    }
}