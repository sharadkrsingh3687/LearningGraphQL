using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.HumanResources
{
    public sealed class GetShiftsQuery: IRequest<IEnumerable<ShiftResponse>>
    {
        // To Do: Add argument if needed.
    }

    public sealed class GetShiftsQueryHandler: IRequestHandler<GetShiftsQuery, IEnumerable<ShiftResponse>>
    {
        private readonly IHumanResourcesService _service;
        public GetShiftsQueryHandler(IHumanResourcesService service) => _service = service;

        public async Task<IEnumerable<ShiftResponse>> Handle(GetShiftsQuery request, CancellationToken cancellationToken)
            => await _service.GetShiftListAsync(cancellationToken).ConfigureAwait(false);
    }
}
