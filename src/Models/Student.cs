using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.src.Models
{
    public class Student
    {
        public required int Id { get; set; }
        public int IdMentor { get; set; }
        public required string Name { get; set; } = string.Empty;
        public required string UserName { get; set; } = string.Empty;
        public required string LastName { get; set; } = string.Empty;
        [EmailAddress]
        public required string PersonalEmail { get; set; } = string.Empty;
        [EmailAddress]
        public required string EmpresarialEmail { get; set; } =  string.Empty;

        public Role? role { get; set; }
        public required int RoleId { get; set; }
        
        
        
    }
}