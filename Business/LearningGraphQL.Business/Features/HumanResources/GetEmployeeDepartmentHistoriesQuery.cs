using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.HumanResources
{
    public sealed class GetEmployeeDepartmentHistoriesQuery: IRequest<IEnumerable<EmployeeDepartmentHistoryResponse>>
    {
        // To Do: Adding arguments for this query.
    }

    public sealed class GetEmployeeDepartmentHistoriesQueryHandler: IRequestHandler<GetEmployeeDepartmentHistoriesQuery, IEnumerable<EmployeeDepartmentHistoryResponse>>
    {
        private readonly IHumanResourcesService _service;
        public GetEmployeeDepartmentHistoriesQueryHandler(IHumanResourcesService service) => _service = service;

        public async Task<IEnumerable<EmployeeDepartmentHistoryResponse>> Handle(GetEmployeeDepartmentHistoriesQuery request, CancellationToken cancellationToken)
            => await this._service.GetEmployeeDepartmentHistoryListAsync(cancellationToken).ConfigureAwait(false);
    }
}
