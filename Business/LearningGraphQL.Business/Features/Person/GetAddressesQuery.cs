using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetAddressesQuery: IRequest<IEnumerable<AddressResponse>>
    {
        // To Do: Add argument if needed.
    }

    public sealed class GetAddressesQueryHandler : IRequestHandler<GetAddressesQuery, IEnumerable<AddressResponse>>
    {
        private readonly IPersonService _service;

        public GetAddressesQueryHandler(IPersonService service) => _service = service;
        public async Task<IEnumerable<AddressResponse>> Handle(GetAddressesQuery request, CancellationToken cancellationToken)
            => await _service.GetAddressListAsync(cancellationToken).ConfigureAwait(false);
    }
}
