using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.src.Models
{
    public class Subject
    {
        private required int Id { get; set; }
        private required int Name { get; set; }
        private required int Hour { get; set; }
        private required String Section { get; set; } = string.empty;
        private required String Paralelo { get; set; } = string.empty;
        private required int CountStudent { get; set; }
        private required String State { get; set; } =string.empty;

        private required List<Student> Students = [];

        
        
    }
}