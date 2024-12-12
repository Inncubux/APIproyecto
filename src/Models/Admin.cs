using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace API.src.Models
{
    public class Admin
    {
        public int Id { get; set; }

        public required string Name { get; set; } = string.Empty; 
        [EmailAddress]
        public required string Email { get; set; } = string.Empty;  
        [EmailAddress]
        public required string PersonalEmail{get; set;}= string.Empty;
        public required string Password { get; set; } = string.Empty;

        public Role? Role { get; set; }

        public required int RoleId { get; set; }

    }
}