using AstroPizza.Application.Common.Interfaces;
using AstroPizza.Domain;

namespace AstroPizza.Application.Toppings
{
    public interface IToppingRepository : IGenericRepository<Topping>
    {
        Task<IReadOnlyList<Topping>> GetToppingsFilteredByVegFlag(bool? isVeg);
    }    
}
