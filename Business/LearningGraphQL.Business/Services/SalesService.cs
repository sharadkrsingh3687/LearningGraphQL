using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Domain.Models.Entities;
using LearningGraphQL.Persist.Contract;
using AutoMapper;

namespace LearningGraphQL.Business.Services
{
    public class SalesService : ISalesService
    {
        private readonly IAdventureWorksDataProvider _dataProvider;
        private readonly IMapper _mapper;

        public SalesService(IMapper mapper, IAdventureWorksDataProvider provider)
        {
            this._dataProvider = provider;
            this._mapper = mapper;
        }
        public async Task<IEnumerable<AwbuildVersionResponse>> GetAwbuildVersionListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetAwbuildVersionsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<AwbuildVersion>, IEnumerable<AwbuildVersionResponse>>(resultSet);   
        }

        public async Task<IEnumerable<CreditCardResponse>> GetCreditCardListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCreditCardsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<CreditCard>, IEnumerable<CreditCardResponse>>(resultSet);
        }

        public async Task<IEnumerable<CurrencyResponse>> GetCurrencyListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCurrenciesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Currency>, IEnumerable<CurrencyResponse>>(resultSet);
        }

        public async Task<IEnumerable<CurrencyRateResponse>> GetCurrencyRateListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCurrencyRatesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<CurrencyRate>, IEnumerable<CurrencyRateResponse>>(resultSet);
        }

        public async Task<IEnumerable<CustomerResponse>> GetCustomerListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCustomersAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Customer>, IEnumerable<CustomerResponse>>(resultSet);
        }

        public async Task<IEnumerable<PersonCreditCardResponse>> GetPersonCreditCardListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPersonCreditCardsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<PersonCreditCard>, IEnumerable<PersonCreditCardResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesOrderDetailResponse>> GetSalesOrderDetailListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesOrderDetailsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesOrderDetail>, IEnumerable<SalesOrderDetailResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesOrderHeaderResponse>> GetSalesOrderHeaderListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesOrderHeadersAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesOrderHeader>, IEnumerable<SalesOrderHeaderResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesOrderHeaderSalesReasonResponse>> GetSalesOrderHeaderSalesReasonListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesOrderHeaderSalesReasonsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesOrderHeaderSalesReason>, IEnumerable<SalesOrderHeaderSalesReasonResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesPersonResponse>> GetSalesPersonListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesPersonsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesPerson>, IEnumerable<SalesPersonResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesReasonResponse>> GetSalesReasonListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesReasonsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesReason>, IEnumerable<SalesReasonResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesTaxRateResponse>> GetSalesTaxRateListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesTaxRatesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesTaxRate>, IEnumerable<SalesTaxRateResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesTerritoryResponse>> GetSalesTerritorieListAsync(CancellationToken cancellationToken)
        {
            
            var resultSet = await _dataProvider.GetSalesTerritoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesTerritory>, IEnumerable<SalesTerritoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<SalesTerritoryHistoryResponse>> GetSalesTerritoryHistoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSalesTerritoryHistoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SalesTerritoryHistory>, IEnumerable<SalesTerritoryHistoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<ShoppingCartItemResponse>> GetShoppingCartItemListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetShoppingCartItemsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ShoppingCartItem>, IEnumerable<ShoppingCartItemResponse>>(resultSet);
        }

        public async Task<IEnumerable<SpecialOfferResponse>> GetSpecialOfferListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSpecialOffersAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SpecialOffer>, IEnumerable<SpecialOfferResponse>>(resultSet);
        }

        public async Task<IEnumerable<SpecialOfferProductResponse>> GetSpecialOfferProductListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetSpecialOfferProductsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<SpecialOfferProduct>, IEnumerable<SpecialOfferProductResponse>>(resultSet);
        }

        public async Task<IEnumerable<StoreResponse>> GetStoreListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetStoresAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Store>, IEnumerable<StoreResponse>>(resultSet);
        }
    }
}
