using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetCountryRegionsQuery: IRequest<IEnumerable<CountryRegionResponse>>
    {
        // To Do: Add arguments if needed.
    }

    public sealed class GetCountryRegionsQueryHandler: IRequestHandler<GetCountryRegionsQuery, IEnumerable<CountryRegionResponse>>
    {
        private readonly IPersonService _service;

        public GetCountryRegionsQueryHandler(IPersonService service) => _service = service;

        public async Task<IEnumerable<CountryRegionResponse>> Handle(GetCountryRegionsQuery request, CancellationToken cancellationToken)
            => await _service.GetCountryRegionListAsync(cancellationToken).ConfigureAwait(false);
    }
}
