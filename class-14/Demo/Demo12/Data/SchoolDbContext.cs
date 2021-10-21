using Demo12.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Demo12.Data
{
    // Inherit from EF Core DbContext
    public class SchoolDbContext : DbContext
    {
        // Allow my context to be configured by magic
        public SchoolDbContext(DbContextOptions options) : base(options) { }

        // Create table called Technologies where a row has properties from Technology
        public DbSet<Technology> Technologies { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        public DbSet<Transcript> Transcripts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Generated, but we don't need it
            // base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Technology>()
                .HasData(
                    new Technology{Id = 1, Name = ".NET"},
                    new Technology{Id = 2, Name = "JavaScript"}
                );

            modelBuilder.Entity<Student>()
                .HasData(
                    new Student { Id = 101, FirstName = "Stacey", LastName = "Teltser" },
                    new Student { Id = 102, FirstName = "Craig", LastName = "Barkley" }
                );

            modelBuilder.Entity<Course>()
                .Property(c => c.Price)
                .HasColumnType("money"); // SQL type for the decimal

            modelBuilder.Entity<Course>()
                .HasData(
                    new Course { Id = 1002, CourseCode = "dotnet-401d5" },
                    new Course { Id = 1005, CourseCode = "201d10", Price = 12 },
                    new Course { Id = 1009, CourseCode = "301d10", Price = 123.45m }
                );

            modelBuilder.Entity<Enrollment>()
                // new { ... } makes an "anonymous type"
                .HasKey(e => new { e.CourseId, e.StudentId });

            modelBuilder.Entity<Enrollment>()
                .HasData(
                    new Enrollment { CourseId = 1002, StudentId = 101 },
                    new Enrollment { CourseId = 1002, StudentId = 102 }
                );

            modelBuilder.Entity<Transcript>()
                .HasData(
                    new Transcript { Id = 1, StudentId = 101, CourseId = 1005, Grade = Grade.A }
                );
        }
    }
} 