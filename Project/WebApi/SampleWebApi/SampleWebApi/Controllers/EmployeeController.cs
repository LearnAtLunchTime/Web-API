using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SampleWebApi.Models; 
namespace SampleWebApi.Controllers
{
    public class EmployeeController : ApiController
    {
        List<Employee> employee;
        public EmployeeController()
        {
            employee = new List<Employee> {
                new Employee() { EmpoyeeId = 12345, FirstName ="Salmanbhai", LastName="Rashid", City ="Teaneck" },
                new Employee() { EmpoyeeId = 12345, FirstName ="Muthu", LastName="Pillai", City ="Edison" },
                new Employee() { EmpoyeeId = 12345, FirstName ="Ping", LastName="Ho", City ="NYC" },
                new Employee() { EmpoyeeId = 12345, FirstName ="Jun", LastName="Jin", City ="NYC" }
            };
        }

        [HttpGet]
        public List<Employee> ReturnEmployee() {

            return employee;
        }

        [HttpGet]
        public Employee Employee(int id)
        {

            return employee[id];
        }

        //[HttpGet]
        //public List<Employee> ReturnEmployees()
        //{

        //    return employee;
        //}

    }
}
