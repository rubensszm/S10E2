using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using S10E2.Models;

namespace S10E2.Controllers
{
    public class DepartmentsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Department> departments = new List<Department> {
                new Department(1, "Electronics"),
                new Department(2, "Fashion")
            };

            return View(departments);
        }
    }
}
