using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Department> Departments = new List<Department>();
            string name = "Eletronics";
            int id = 1;
            Departments.Add(new Department(id, name));
            name = "Fashion";
            id = 2;
            Departments.Add(new Department(id, name));

            return View(Departments);
        }
    }
}
