using Demo12.Data;
using Demo12.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Services.Database
{
    public class DatabaseTechnologyRepository : ITechnologyRepository
    {
        private readonly SchoolDbContext _context;

        public DatabaseTechnologyRepository(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<List<Technology>> GetAll()
        {
            return await _context.Technologies.ToListAsync();
        }

        public async Task<Technology> GetById(int id)
        {
            return await _context.Technologies.FindAsync(id);
        }

        public async Task Insert(Technology technology)
        {
            _context.Technologies.Add(technology);
            await _context.SaveChangesAsync();
            // TODO: use API to notify Slack of new technology
        }

        public async Task<bool> TryDelete(int id)
        {
            var technology = await _context.Technologies.FindAsync(id);
            if (technology == null)
            {
                // Delete failed
                return false;
            }

            _context.Technologies.Remove(technology);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
