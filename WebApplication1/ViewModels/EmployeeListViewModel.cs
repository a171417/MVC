using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewMode> Employees { get; set};
        public string UserName { get; set; }
    }
}