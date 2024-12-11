using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.src.Models
{
    public class Student
    {
        public required int Id { get; set; }
        public int IdMentor { get; set; }
        public required String Name { get; set; } = string.empty;
        public required String UserName { get; set; } = string.empty;
        public required String LastName { get; set; } = string.empty;
        [EmailAddress]
        public required String PersonalEmail { get; set; } = string.empty;
        [EmailAddress]
        public required String EmpresarialEmail { get; set; } =string.Empty;

        public Role role { get; set; }
        public int RoleId { get; set; }
        
        
        
    }
}