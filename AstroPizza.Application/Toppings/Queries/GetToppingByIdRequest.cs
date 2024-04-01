using AutoMapper;
using MediatR;

namespace AstroPizza.Application.Toppings.Queries
{
    public record GetToppingByIdRequest(int ToppingId) : IRequest<ToppingDto>
    {
    }

    public class GetToppingByIdRequestHandler : IRequestHandler<GetToppingByIdRequest, ToppingDto>
    {
        private readonly IToppingRepository _toppingRepository;
        private readonly IMapper _mapper;

        public GetToppingByIdRequestHandler(IToppingRepository toppingRepository, IMapper mapper)
        {
            _toppingRepository = toppingRepository;
            _mapper = mapper;
        }

        public async Task<ToppingDto> Handle(GetToppingByIdRequest request, CancellationToken cancellationToken)
        {
            var topping = await _toppingRepository.GetAsync(request.ToppingId);

            return _mapper.Map<ToppingDto>(topping);
        }
    }
}
