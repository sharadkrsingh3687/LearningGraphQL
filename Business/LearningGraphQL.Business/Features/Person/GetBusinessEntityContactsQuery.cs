using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetBusinessEntityContactsQuery: IRequest<IEnumerable<BusinessEntityContactResponse>>
    {
        // To Do: Add argument if needed.
    }

    public sealed class GetBusinessEntityContactsQueryHandler : IRequestHandler<GetBusinessEntityContactsQuery, IEnumerable<BusinessEntityContactResponse>>
    {
        private readonly IPersonService _service;

        public GetBusinessEntityContactsQueryHandler(IPersonService service) => _service = service;
        public async Task<IEnumerable<BusinessEntityContactResponse>> Handle(GetBusinessEntityContactsQuery request, CancellationToken cancellationToken)
            => await _service.GetBusinessEntityContactListAsync(cancellationToken).ConfigureAwait(false);
    }
}
