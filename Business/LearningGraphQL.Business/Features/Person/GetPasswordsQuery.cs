using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Person
{
    public sealed class GetPasswordsQuery: IRequest<IEnumerable<PasswordResponse>>
    {
        // To Do: Add arguments if needed.
    }

    public sealed class GetPassowordsQueryHandler: IRequestHandler<GetPasswordsQuery, IEnumerable<PasswordResponse>>
    {
        private readonly IPersonService _service;

        public GetPassowordsQueryHandler(IPersonService service) => _service = service;

        public async Task<IEnumerable<PasswordResponse>> Handle(GetPasswordsQuery request, CancellationToken cancellationToken)
            => await _service.GetPasswordListAsync(cancellationToken).ConfigureAwait(false);
    }
}
