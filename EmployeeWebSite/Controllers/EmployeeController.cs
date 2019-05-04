using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebSite.Models;

namespace EmployeeWebSite.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Index()
        {
            Models.DataManager.EmployeeData employeeData = new Models.DataManager.EmployeeData();
            List<Employee> employeeList = employeeData.ReturnEmployees();
            return employeeList;

        }


    }
}
