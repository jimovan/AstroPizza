using AstroPizza.Domain;
using AutoMapper;
using MediatR;

namespace AstroPizza.Application.Toppings.Queries
{
    public record GetToppingsListRequest : IRequest<List<ToppingDto>>
    {
        public bool? IsVegetarian { get; set; }
    }

    public class GetToppingsListRequestHandler : IRequestHandler<GetToppingsListRequest, List<ToppingDto>>
    {
        private readonly IToppingRepository _toppingRepository;
        private readonly IMapper _mapper;

        public GetToppingsListRequestHandler(IToppingRepository toppingRepository, IMapper mapper)
        {
            _toppingRepository = toppingRepository;
            _mapper = mapper;
        }

        public async Task<List<ToppingDto>> Handle(GetToppingsListRequest request, CancellationToken cancellationToken)
        {
            IReadOnlyList<Topping> toppings;

            if (request.IsVegetarian.HasValue)
            {
                toppings = await _toppingRepository.GetToppingsFilteredByVegFlag(request.IsVegetarian);
            }
            else
            {
                toppings = await _toppingRepository.GetAllAsync();
            }

            return _mapper.Map<List<ToppingDto>>(toppings);
        }
    }
}
