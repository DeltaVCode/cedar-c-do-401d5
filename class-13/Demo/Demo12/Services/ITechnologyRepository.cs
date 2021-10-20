using Demo12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo12.Services
{
    public interface ITechnologyRepository
    {
        Task<List<Technology>> GetAll();

        Task<Technology> GetById(int id);

        // Task alone ~= return void, but awaitable
        Task Insert(Technology technology);
    }
}
