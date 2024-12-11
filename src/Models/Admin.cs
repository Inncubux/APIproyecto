using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.src.Models
{
    public class Admin
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty; 
        [emailAddress]
        public string Email { get; set; } = string.Empty;  

        public string Password { get; set; } = string.Empty;

        public Role Role { get; set; }

        public required int RoleId { get; set; }

    }
}