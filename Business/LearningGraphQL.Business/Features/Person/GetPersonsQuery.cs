using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetPersonsQuery: IRequest<IEnumerable<PersonResponse>>
    {
        // To Do: Add arguments in needed.
    }

    public sealed class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, IEnumerable<PersonResponse>>
    {
        private readonly IPersonService _service;
        public GetPersonsQueryHandler(IPersonService service) => _service = service;
        public async Task<IEnumerable<PersonResponse>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
            => await _service.GetPersonListAsync(cancellationToken).ConfigureAwait(false);
    }
}
