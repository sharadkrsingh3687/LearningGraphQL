using MediatR;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Business.Contract.Services;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetAddressTypesQuery: IRequest<IEnumerable<AddressTypeResponse>>
    {
        // To Do: Add argument if needed
    }

    public sealed class GetAddressTypesQueryHandler: IRequestHandler<GetAddressTypesQuery, IEnumerable<AddressTypeResponse>>
    {
        private readonly IPersonService _service;
        public GetAddressTypesQueryHandler(IPersonService service) => _service = service;

        public async Task<IEnumerable<AddressTypeResponse>> Handle(GetAddressTypesQuery request, CancellationToken cancellationToken)
            => await _service.GetAddressTypeListAsync(cancellationToken).ConfigureAwait(false);
    }
}
