using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiEmployee.Models;

namespace WebApiEmployee.Controllers
{
    public class EmployeesController : ApiController
    {
        List<Employee> employeeList;

        public EmployeesController()
        {
            

            employeeList = new List<Employee> {
                    new Employee() { EmployeeId = 12345, FirstName = "Dhaval", LastName = "Patel", City = "Kendall Park" },
                    new Employee() { EmployeeId = 12345, FirstName = "Salman", LastName = "Rashid", City = "Teaneck" },
                    new Employee() { EmployeeId = 12345, FirstName = "Dhaval", LastName = "Patel", City = "Kendall Park" },
                    new Employee() { EmployeeId = 12345, FirstName = "Dhaval", LastName = "Patel", City = "Kendall Park" },


            };
        }

        public List<Employee> GetEmployee() {


            return employeeList;
        }
    }
}
