using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetBusinessEntityAddressesQuery: IRequest<IEnumerable<BusinessEntityAddressResponse>>
    {
        // To Do: Add argument if need
    }

    public sealed class GetBusinessEntityAddressesQueryHandler : IRequestHandler<GetBusinessEntityAddressesQuery, IEnumerable<BusinessEntityAddressResponse>>
    {
        private readonly IPersonService _service;

        public GetBusinessEntityAddressesQueryHandler(IPersonService service) => _service = service;
        public async Task<IEnumerable<BusinessEntityAddressResponse>> Handle(GetBusinessEntityAddressesQuery request, CancellationToken cancellationToken)
            => await _service.GetBusinessEntityAddressListAsync(cancellationToken).ConfigureAwait(false);
    }
}
