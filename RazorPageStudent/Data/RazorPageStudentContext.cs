using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageStudent.Models;

namespace RazorPageStudent.Data
{
    public class RazorPageStudentContext : DbContext
    {
        public RazorPageStudentContext (DbContextOptions<RazorPageStudentContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageStudent.Models.Student> Student { get; set; } = default!;

        public DbSet<RazorPageStudent.Models.Course>? Course { get; set; }

        public DbSet<RazorPageStudent.Models.Staff>? Staff { get; set; }

        public DbSet<RazorPageStudent.Models.Clazz>? Clazz { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Staff)
                .WithMany(s => s.Students);


            modelBuilder.Entity<Student>()
                .HasMany(s => s.Staffs)
                .WithMany(s => s.Student);



            base.OnModelCreating(modelBuilder);
        }

    }
}
