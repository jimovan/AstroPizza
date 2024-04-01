using AstroPizza.Application.Common;
using AstroPizza.Domain;
using AutoMapper;

namespace AstroPizza.Application.Toppings
{
    public record ToppingDto : BaseDto
    {   
        public string Name { get; set; }

        private class Mapping : Profile
        {
            public Mapping() 
            {
                CreateMap<Topping, ToppingDto>();
            }
        }
    }    
}
