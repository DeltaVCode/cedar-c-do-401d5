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

        /// <summary>
        /// Try to delete, but return false if <paramref name="id"/> not found.
        /// </summary>
        /// <param name="id">The id to delete.</param>
        /// <returns>Task with value of <c>true</c> if delete worked; false if not found.</returns>
        Task<bool> TryDelete(int id);
    }
}
