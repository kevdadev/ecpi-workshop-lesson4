using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace EmployeeWebSite.Models.DataManager
{
    public class EmployeeData
    {
        private List<Employee> CreateEmployeeData()
        {
            List<Employee> employeeList = new List<Employee>();

            Employee emp1 = new Employee();
            emp1.EmployeeID = 1;
            emp1.FirstName = "Jane";
            emp1.LastName = "Doe";
            emp1.EmailAddress = "janedoe@gmail.com";
            emp1.PhoneNumber = "(804)333-4444";
            emp1.DateOfBirth = new DateTime(1990,02, 15);
            employeeList.Add(emp1);

            Employee emp2 = new Employee
            {
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "(804)222-5555",
                EmailAddress = "johndoe@gmail.com",
                EmployeeID = 2,
                DateOfBirth = new DateTime(1989,11,5)
            };
            employeeList.Add(emp2);

            return employeeList;
        }
        
        public List<Employee> ReturnEmployees()
        {
            List<Employee> employeeList = CreateEmployeeData();
            return employeeList;
        }

        public List<Employee> AddNewEmployee(Employee newEmployee)
        {
            List<Employee> employeeList = CreateEmployeeData();
            employeeList.Add(newEmployee);
            return employeeList;
        }

    }
}
