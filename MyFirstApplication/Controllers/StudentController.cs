using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApplication.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        [Route("")]
        public string Phone()
        {
            return "+91-987654321";
        }
        [Route("[action]")]
        public string Country()
        {
            return "India";
        }
    }
}
