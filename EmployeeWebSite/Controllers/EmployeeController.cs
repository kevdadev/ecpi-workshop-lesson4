using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeWebSite.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Formatting;

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
        [HttpPost]
        public ActionResult<IEnumerable<Employee>> AddNew(IFormCollection postedform)
        {
            var firstName = String.Empty;
            var lastName = String.Empty;
            var emailAddress = String.Empty;
            var phoneNumber = String.Empty;
            var employeeId = 3;
            var year = 0;
            var month = 0;
            var day = 0;
            //Mapping - form to variable
            firstName = postedform["firstname"];
            lastName = postedform["lastname"];
            emailAddress = postedform["emailaddress"];
            phoneNumber = postedform["phonenumber"];
            year = int.Parse(postedform["year"]);
            month = int.Parse(postedform["month"]);
            day = int.Parse(postedform["day"]);

            //Mapping variable to object 
            Employee newEmployee = new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                EmailAddress = emailAddress,
                EmployeeID = employeeId,
                PhoneNumber = phoneNumber,
                DateOfBirth = new DateTime(year,month,day)
            };

            Models.DataManager.EmployeeData employeeData = new Models.DataManager.EmployeeData();
            List<Employee> employeeList = employeeData.AddNewEmployee(newEmployee);
            return employeeList;
        }

    }
}
