using ApiBusinessLayer.Interface;
using ApiEntities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPractice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeComponent _employeeComponent;
        
        public EmployeeController(IEmployeeComponent employeeComponent)
        {
            _employeeComponent = employeeComponent;
        }
       [HttpGet]
        //[Authorize]
        public IActionResult CreateEmployee()
        {
            return Ok(_employeeComponent.GetEmployee());
        }
        [HttpDelete]
        public IActionResult DeleteEmployee(long Id)
        {
            var result = _employeeComponent.DeleteEmployee(Id);
            return Ok("Employee deleted Successfully");
        }
        [HttpPost]
        public IActionResult AddNewEmployee(Employee emp)
        {
            _employeeComponent.AddEmployee(emp);
            return Ok("Employee Has been added");
        }
    }
}
