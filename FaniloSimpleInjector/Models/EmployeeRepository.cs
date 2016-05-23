using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FaniloSimpleInjector.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public List<Employee> GetEmployees()
        {
            var employee = new List<Employee>
            {
                new Employee{Id=1,FirstName = "John", LastName = "Brown",Year =24},
                new Employee{Id=2,FirstName = "Brad",LastName = "Ferduson" , Year =28},
                new Employee{Id=2,FirstName = "Bill",LastName = "Billy" , Year =28}
            };
            return employee;
        }
    }
}