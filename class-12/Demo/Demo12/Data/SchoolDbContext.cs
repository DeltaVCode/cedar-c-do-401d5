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
    }
} 