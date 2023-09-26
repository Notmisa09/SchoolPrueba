using Microsoft.EntityFrameworkCore;
using School.Domain.ENTITIES;
using System;
using System.Collections.Generic;
using System.Text;

namespace School.Infraestructure.CONTEXT
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }

    }
}
