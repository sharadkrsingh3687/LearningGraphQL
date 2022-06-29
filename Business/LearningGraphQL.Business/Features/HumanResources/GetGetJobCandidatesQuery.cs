using MediatR;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Business.Contract.Services;

namespace LearningGraphQL.Business.Features.HumanResources
{
    public sealed class GetGetJobCandidatesQuery: IRequest<IEnumerable<JobCandidateResponse>>
    {
        // To Do: Add arguments for this query.
    }

    public sealed class GetJobCandidatesQueryHandler: IRequestHandler<GetGetJobCandidatesQuery,IEnumerable<JobCandidateResponse>>
    {
        private readonly IHumanResourcesService _service;

        public GetJobCandidatesQueryHandler(IHumanResourcesService service) => _service = service;

        public async Task<IEnumerable<JobCandidateResponse>> Handle(GetGetJobCandidatesQuery request, CancellationToken cancellationToken)
            => await this._service.GetJobCandidateListAsync(cancellationToken).ConfigureAwait(false);
    }
}
