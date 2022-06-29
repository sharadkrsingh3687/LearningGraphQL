using MediatR;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Business.Contract.Services;

namespace LearningGraphQL.Business.Features.HumanResources
{
    public sealed class GetEmployeePayHistoriesQuery: IRequest<IEnumerable<EmployeePayHistoryResponse>>
    {
        // To Do: Adding argument for this query.
    }

    public sealed class GetEmployeePayHistoriesQueryHandler : IRequestHandler<GetEmployeePayHistoriesQuery, IEnumerable<EmployeePayHistoryResponse>>
    {
        private readonly IHumanResourcesService _service;

        public GetEmployeePayHistoriesQueryHandler(IHumanResourcesService service) => _service = service;
        public async Task<IEnumerable<EmployeePayHistoryResponse>> Handle(GetEmployeePayHistoriesQuery request, CancellationToken cancellationToken)
            => await this._service.GetEmployeePayHistoryListAsync(cancellationToken).ConfigureAwait(false);
    }
}
