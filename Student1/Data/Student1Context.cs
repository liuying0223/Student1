#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student1.Models;

namespace Student1.Data
{
    public class Student1Context : DbContext
    {
        public Student1Context (DbContextOptions<Student1Context> options)
            : base(options)
        {
        }

        public DbSet<Student1.Models.Student> Student { get; set; }
    }
}
