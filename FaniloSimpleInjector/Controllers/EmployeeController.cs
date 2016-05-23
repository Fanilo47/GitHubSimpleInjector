using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FaniloSimpleInjector.Models;

namespace FaniloSimpleInjector.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeRepository Employeerepository;
        public EmployeeController(IEmployeeRepository employeerepository)
        {
            Employeerepository = employeerepository;
        }
        //
        // GET: /Employee/
        public ActionResult Index()
        {
            var customer = Employeerepository.GetEmployees();
            return View(customer);
        }
	}
}