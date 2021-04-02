using ApiBusinessLayer.Interface;
using ApiEntities.CustomEntities;
using ApiEntities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WebApiPractice.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly IEmployeeComponent _employeeComponent;
        private readonly IConfiguration _config;
        public LoginController(IEmployeeComponent employeeComponent, IConfiguration config)
        {
            _employeeComponent = employeeComponent;
            _config = config;
        }
        [HttpGet]
        //[Authorize(Roles="Developer")]
        public IActionResult LoginMethod([FromQuery] LoginModel loginModel)
        {
            
            var userInfo = _employeeComponent.GetUsers().Where(x => x.Username == loginModel.Username && x.Password == loginModel.Password
              && x.IsActive == true).FirstOrDefault();
            var token = GenerateJSONWebToken(userInfo);
            return Ok(token);
        }
        private string GenerateJSONWebToken(LoginCredentials userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[] { new Claim(ClaimTypes.Name, userInfo.DisplayName), new Claim(ClaimTypes.Role, userInfo.RoleName) };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(30),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
