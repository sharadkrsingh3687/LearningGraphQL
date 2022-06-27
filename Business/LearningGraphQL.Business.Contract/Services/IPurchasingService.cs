using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Contract.Services
{
    public interface IPurchasingService
    {
        Task<IEnumerable<ProductVendorResponse>> GetProductVendorListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PurchaseOrderDetailResponse>> GetPurchaseOrderDetailListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PurchaseOrderHeaderResponse>> GetPurchaseOrderHeaderListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ShipMethodResponse>> GetShipMethodListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<VendorResponse>> GetVendorListAsync(CancellationToken cancellationToken);
    }
}
