using MediatR;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Features.Production
{
    public sealed class GetProductsQuery: IRequest<IEnumerable<ProductResponse>>
    {
        // To Do: add argument here if have any then
    }

    public sealed class GetProductsQueryHandler: IRequestHandler<GetProductsQuery, IEnumerable<ProductResponse>>
    {
        private readonly IProductionService _service;

        public GetProductsQueryHandler(IProductionService service) => _service = service;

        public async Task<IEnumerable<ProductResponse>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
            => await this._service.GetProductListAsync(cancellationToken).ConfigureAwait(false);
    }
}
