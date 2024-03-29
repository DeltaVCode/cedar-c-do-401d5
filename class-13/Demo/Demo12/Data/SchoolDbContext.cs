﻿using Demo12.Models;
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
        }
    }
} 