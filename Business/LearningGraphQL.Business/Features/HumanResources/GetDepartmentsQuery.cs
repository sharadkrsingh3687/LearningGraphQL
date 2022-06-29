using MediatR;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Business.Contract.Services;

namespace LearningGraphQL.Business.Features.HumanResources
{
    public sealed class GetDepartmentsQuery: IRequest<IEnumerable<DepartmentResponse>>
    {
        // To Do: Need to add arguments if have any.
    }

    public sealed class GetDepartmentsQueryHandler: IRequestHandler<GetDepartmentsQuery, IEnumerable<DepartmentResponse>>
    {
        private readonly IHumanResourcesService _service;
        public GetDepartmentsQueryHandler(IHumanResourcesService service) => _service = service;

        public async Task<IEnumerable<DepartmentResponse>> Handle(GetDepartmentsQuery request, CancellationToken cancellationToken)
            => await this._service.GetDepartmentListAsync(cancellationToken).ConfigureAwait(false);
    }
}
