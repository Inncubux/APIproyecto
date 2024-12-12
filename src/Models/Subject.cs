using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.src.Models
{
    public class Subject
    {
        public required string Id { get; set; } =string.Empty;
        public required string Name { get; set; } = string.Empty;
        public required int Hour { get; set; }
        public required string Section { get; set; } = string.Empty;
        public required int CountStudent { get; set; }
        public required string State { get; set; } =  string.Empty;
        public required List<Student> Students = [];
        
    }
}