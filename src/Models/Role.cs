using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.src.Models
{
    public class Role
    {
        public required int Id {get; set;}
        public required string Name {get; set;} = string.Empty;
    }
}