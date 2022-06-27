using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Contract.Services
{
    public interface IProductionService
    {
        Task<IEnumerable<BillOfMaterialsResponse>> GetBillOfMaterialsListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CultureResponse>> GetCultureListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<IllustrationResponse>> GetIllustrationListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<LocationResponse>> GetLocationListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductResponse>> GetProductListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductCategoryResponse>> GetProductCategoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductCostHistoryResponse>> GetProductCostHistoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductDescriptionResponse>> GetProductDescriptionListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductInventoryResponse>> GetProductInventoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductListPriceHistoryResponse>> GetProductListPriceHistoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductModelResponse>> GetProductModelListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductModelIllustrationResponse>> GetProductModelIllustrationListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductModelProductDescriptionCultureResponse>> GetProductModelProductDescriptionCultureListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductPhotoResponse>> GetProductPhotoListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductProductPhotoResponse>> GetProductProductPhotoListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductReviewResponse>> GetProductReviewListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ProductSubcategoryResponse>> GetProductSubcategoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ScrapReasonResponse>> GetScrapReasonListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<TransactionHistoryResponse>> GetTransactionHistoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<TransactionHistoryArchiveResponse>> GetTransactionHistoryArchiveListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<UnitMeasureResponse>> GetUnitMeasureListAsync(CancellationToken cancellationToken);

        Task<IEnumerable<WorkOrderResponse>> GetWorkOrderListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<WorkOrderRoutingResponse>> GetWorkOrderRoutingListAsync(CancellationToken cancellationToken);
    }
}
