using MediatR;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Business.Contract.Services;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetContactTypesQuery: IRequest<IEnumerable<ContactTypeResponse>>
    {
        // To Do: Add arguments if needed
    }

    public sealed class GetContanctTypesQueryHandler : IRequestHandler<GetContactTypesQuery, IEnumerable<ContactTypeResponse>>
    {
        private readonly IPersonService _service;

        public GetContanctTypesQueryHandler(IPersonService service) => _service = service;

        public async Task<IEnumerable<ContactTypeResponse>> Handle(GetContactTypesQuery request, CancellationToken cancellationToken)
        => await _service.GetContactTypeListAsync(cancellationToken).ConfigureAwait(false);
    }
}
