using Demo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Services.Database
{
    public class DatabaseStudentRepository : IStudentRepository
    {
        public DatabaseStudentRepository()
        {
        }

        public async Task<List<Student>> GetAll()
        {
            return new List<Student>
            {
                new Student { FirstName = "Keith" },
            };
        }
    }
}
