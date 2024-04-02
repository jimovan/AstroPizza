using AstroPizza.Application.Toppings;
using AstroPizza.Application.Toppings.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AstroPizza.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToppingsController : BaseController
    {
        public ToppingsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet(Name = "GetToppings")]
        public async Task<List<ToppingDto>> Get()
        {
            var toppings = await _mediator.Send(new GetToppingsListRequest());

            return toppings;
        }

        [HttpGet("{toppingId}", Name = "GetToppingById")] 
        public async Task<ToppingDto> GetById(int toppingId)
        {
            var topping = await _mediator.Send(new GetToppingByIdRequest(toppingId));

            return topping;
        }

        [HttpGet("toppings/getvegetarian", Name = "GetVegetarianToppings")]
        public async Task<List<ToppingDto>> GetVegetarianToppings()
        {
            var toppings = await _mediator.Send(new GetToppingsListRequest() { IsVegetarian = true});

            return toppings;
        }

        [HttpGet("toppings/getmeat", Name = "GetMeatToppings")]
        public async Task<List<ToppingDto>> GetMeatToppings()
        {
            var toppings = await _mediator.Send(new GetToppingsListRequest() { IsVegetarian = false });

            return toppings;
        }
    }
}
