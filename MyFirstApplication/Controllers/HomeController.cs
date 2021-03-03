using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyFirstApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<EmployeeViewModel> employeeList;
        List<object> li;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            employeeList = new List<EmployeeViewModel>();
            li = new List<object>();
            li.Add(2);
            employeeList.Add(new EmployeeViewModel
            {
                Id = 1,
                Name="parneet kaur",
                Age="21",
                Salary="20000",
                Designation="Developer",
                Edit="Edit",
                Gender="Female",
                Email="test1@gmail.com",
                Country = new[] { 1 },
                TypeGender=2
            }) ;

            employeeList.Add(new EmployeeViewModel
            {
                Id = 2,
                Name = "rahul saini",
                Age = "21",
                Salary = "40000",
                Designation = "Developer",
                Edit = "Edit",
                Gender = "Male",
                Email = "test2@gmail.com",
                Country = new[] { 2 },
                TypeGender = 1
            });

            employeeList.Add(new EmployeeViewModel
            {
                Id = 3,
                Name = "pankaj verma",
                Age = "22",
                Salary = "20000",
                Designation = "Developer",
                Edit = "Edit",
                Gender = "Male",
                Email = "test3@gmail.com",
                Country=new[] {3},
                TypeGender = 1
            });

            employeeList.Add(new EmployeeViewModel
            {
                Id = 4,
                Name = "sajal bansal",
                Age = "21",
                Salary = "20000",
                Designation = "Developer",
                Edit = "Edit",
                Gender = "Female",
                Email = "test4@gmail.com",
                Country = new[] { 4 },
                TypeGender = 2
            });

            employeeList.Add(new EmployeeViewModel
            {
                Id = 5,
                Name = "mahak bansal",
                Age = "22",
                Salary = "40000",
                Designation = "Developer",
                Edit = "Edit",
                Gender = "Female",
                Email = "test5@gmail.com",
                Country = new[] { 5 },
                TypeGender = 2
            });

            
        }
        public ContentResult Index3()
        {
            return Content("Hello, World! this message is from Home Controller using the Action Result"); 
      }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
        public IActionResult EmployeeDetails()
        {
            return View(employeeList);
        }
        [HttpGet]
        public IActionResult EditEmployee(long id)
        {
            var model = new EmployeeViewModel();
            if(id>0)
            {
                model=  employeeList.FirstOrDefault(x => x.Id == id);
            }
            return View("EditEmployeePartial", model);
        }
        [HttpPost]
        public IActionResult EditEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(EmployeeDetails));
            }
            else
                return View("EditEmployeePartial", model);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
