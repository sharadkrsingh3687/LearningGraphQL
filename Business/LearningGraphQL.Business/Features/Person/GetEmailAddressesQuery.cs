using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetEmailAddressesQuery: IRequest<IEnumerable<EmailAddressResponse>>
    {
        // To Do: Add argument if needed.
    }

    public sealed class GetEmailAddressesQueryHandler: IRequestHandler<GetEmailAddressesQuery, IEnumerable<EmailAddressResponse>>
    {
        private readonly IPersonService _service;
        public GetEmailAddressesQueryHandler(IPersonService service) => _service = service;

        public async Task<IEnumerable<EmailAddressResponse>> Handle(GetEmailAddressesQuery request, CancellationToken cancellationToken)
            => await _service.GetEmailAddressListAsync(cancellationToken).ConfigureAwait(false);
    }
}
