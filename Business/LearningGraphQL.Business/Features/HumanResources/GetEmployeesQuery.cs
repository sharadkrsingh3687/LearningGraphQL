using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;
using MediatR;

namespace LearningGraphQL.Business.Features.HumanResources
{
    public sealed class GetEmployeesQuery: IRequest<IEnumerable<EmployeeResponse>>
    {
        // To Do: Need to add arguments if have any.
    }

    public sealed class GetEmployeesQueryHandler: IRequestHandler<GetEmployeesQuery, IEnumerable<EmployeeResponse>>
    {
        private readonly IHumanResourcesService _service;
        public GetEmployeesQueryHandler(IHumanResourcesService service) => _service = service;

        public async Task<IEnumerable<EmployeeResponse>> Handle(GetEmployeesQuery request, CancellationToken cancellationToken)
            =>  await this._service.GetEmployeeListAsync(cancellationToken).ConfigureAwait(false);           
    }
}
