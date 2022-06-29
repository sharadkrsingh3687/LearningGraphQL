using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetCountryRegionCurrenciesQuery: IRequest<IEnumerable<CountryRegionCurrencyResponse>>
    {
        // To Do: Add arguments if needed.
    }

    public sealed class GetCountryRegionCurrenciesQueryHandler: IRequestHandler<GetCountryRegionCurrenciesQuery, IEnumerable<CountryRegionCurrencyResponse>>
    {
        private readonly IPersonService _service;
        public GetCountryRegionCurrenciesQueryHandler(IPersonService service) => _service = service;

        public async Task<IEnumerable<CountryRegionCurrencyResponse>> Handle(GetCountryRegionCurrenciesQuery request, CancellationToken cancellationToken)
            => await _service.GetCountryRegionCurrencyListAsync(cancellationToken).ConfigureAwait(false);
    }
}
