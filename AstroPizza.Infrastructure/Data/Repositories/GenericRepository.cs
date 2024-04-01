using AstroPizza.Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AstroPizza.Infrastructure.Data.Repositories
{
    public class GenericRepository<T>(AstroPizzaDbContext dbContext) : IGenericRepository<T> where T : class
    {
        private readonly AstroPizzaDbContext _dbContext = dbContext;

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int id)
        {
            return await _dbContext.Set<T>().FindAsync(id);
        }

        public Task<T> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }        

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
