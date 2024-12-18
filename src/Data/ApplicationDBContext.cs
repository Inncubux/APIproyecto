using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using API.src.Models;
using Microsoft.EntityFrameworkCore;

namespace API.src.Data
{
    public class ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : DbContext(options)
    {
        public DbSet<Admin> Admins { get; set; } = null!; 

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Student> Students { get; set; } = null!;

        public DbSet<Subject> Subjects { get; set; } = null!;

        
    }
}