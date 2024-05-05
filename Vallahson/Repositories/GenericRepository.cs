using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vallahson.Context;
using Vallahson.Interfaces;

namespace Vallahson.Repositories
{
    internal class GenericRepository<T> : IGenericRepository<T> where T : class, new()
    {
        private readonly YourDbContext _context;
        public DbSet<T> Table { get; set; }
        public GenericRepository()
        {
            _context = new YourDbContext();
            Table = _context.Set<T>();
        }
        public async Task Add(T entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Table.ToListAsync();
        }

        public void Remove(T entity)
        {
            Table.Remove(entity);
        }

        public void Update(T entity)
        {
            Table.Update(entity);
        }

        public async Task<T> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
