
using MediatR;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Business.Contract.Services;

namespace LearningGraphQL.Business.Features.Production
{
    public sealed class GetLocationsQuery: IRequest<IEnumerable<LocationResponse>>
    {
      
    }

    public sealed class GetLocationsQueryHandler: IRequestHandler<GetLocationsQuery, IEnumerable<LocationResponse>>
    {
        private readonly IProductionService _service;

        public GetLocationsQueryHandler(IProductionService service) => _service = service;

        public  async Task<IEnumerable<LocationResponse>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
            => await this._service.GetLocationListAsync(cancellationToken).ConfigureAwait(false);
    }
}
