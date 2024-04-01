using AstroPizza.Application.Toppings;
using AstroPizza.Domain;
using Microsoft.EntityFrameworkCore;

namespace AstroPizza.Infrastructure.Data.Repositories
{
    public class ToppingRepository(AstroPizzaDbContext dbContext) : GenericRepository<Topping>(dbContext), IToppingRepository
    {
        private readonly AstroPizzaDbContext _dbContext = dbContext;        

        public async Task<IReadOnlyList<Topping>> GetToppingsFilteredByVegFlag(bool? isVeg)
        {
            return await _dbContext.Set<Topping>().Where(t => t.IsVegetarian == isVeg).ToListAsync();
        }
    }
}
