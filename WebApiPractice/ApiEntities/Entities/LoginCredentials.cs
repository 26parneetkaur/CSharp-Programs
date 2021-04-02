using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace ApiEntities.Entities
{
    public partial class LoginCredentials
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
        public string RoleName { get; set; }
    }
}
