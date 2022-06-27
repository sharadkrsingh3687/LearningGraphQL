using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Contract.Services
{
    public interface ISalesService
    {
        Task<IEnumerable<AwbuildVersionResponse>> GetAwbuildVersionListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CreditCardResponse>> GetCreditCardListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CurrencyResponse>> GetCurrencyListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CurrencyRateResponse>> GetCurrencyRateListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CustomerResponse>> GetCustomerListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PersonCreditCardResponse>> GetPersonCreditCardListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesOrderDetailResponse>> GetSalesOrderDetailListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesOrderHeaderResponse>> GetSalesOrderHeaderListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesOrderHeaderSalesReasonResponse>> GetSalesOrderHeaderSalesReasonListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesPersonResponse>> GetSalesPersonListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesTaxRateResponse>> GetSalesTaxRateListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesTerritoryResponse>> GetSalesTerritorieListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesTerritoryHistoryResponse>> GetSalesTerritoryHistoryListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SalesReasonResponse>> GetSalesReasonListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ShoppingCartItemResponse>> GetShoppingCartItemListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SpecialOfferResponse>> GetSpecialOfferListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<SpecialOfferProductResponse>> GetSpecialOfferProductListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<StoreResponse>> GetStoreListAsync(CancellationToken cancellationToken);

    }
}
