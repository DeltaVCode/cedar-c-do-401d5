using Microsoft.EntityFrameworkCore;
using System;

namespace Demo12.Data
{
    // Inherit from EF Core DbContext
    public class SchoolDbContext : DbContext
    {
        // Allow my context to be configured by magic
        public SchoolDbContext(DbContextOptions options) : base(options) { }
    }
} 