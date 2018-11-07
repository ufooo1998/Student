using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace StudentManager.Models
{
    public class StudentManagerContext : DbContext
    {
        public StudentManagerContext (DbContextOptions<StudentManagerContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManager.Models.Student> Student { get; set; }
    }
}
