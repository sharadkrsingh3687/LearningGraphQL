
using System.Linq;
using LearningGraphQL.Persist.Contract;
using LearningGraphQL.Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningGraphQL.Persist
{
    public class AdventureWorksDataProvider : ProviderBase<AdventureWorksDataProvider>, IAdventureWorksDataProvider
    {
        private readonly IAdventureWorksDbContext _dbContext = null!;
        public AdventureWorksDataProvider(IAdventureWorksDbContext dbContext) : base((AdventureWorksDbContext)dbContext)
            => _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));

        public async Task<IEnumerable<Address>> GetAddresssAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Address>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<AddressType>> GetAddressTypesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<AddressType>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<AwbuildVersion>> GetAwbuildVersionsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<AwbuildVersion>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<BillOfMaterials>> GetBillOfMaterialsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<BillOfMaterials>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<BusinessEntity>> GetBusinessEntitiesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<BusinessEntity>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<BusinessEntityAddress>> GetBusinessEntityAddresssAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<BusinessEntityAddress>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<BusinessEntityContact>> GetBusinessEntityContactsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<BusinessEntityContact>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ContactType>> GetContactTypesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ContactType>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<CountryRegion>> GetCountryRegionsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<CountryRegion>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<CountryRegionCurrency>> GetCountryRegionCurrenciesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<CountryRegionCurrency>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<CreditCard>> GetCreditCardsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<CreditCard>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Culture>> GetCulturesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Culture>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Currency>> GetCurrenciesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Currency>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<CurrencyRate>> GetCurrencyRatesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<CurrencyRate>(cancellationToken);

        public async Task<IEnumerable<UnitMeasure>> GetUnitMeasuresAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<UnitMeasure>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Vendor>> GetVendorsAsync(CancellationToken  cancellationToken)
            => await GetListDataAsync<Vendor>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<WorkOrder>> GetWorkOrdersAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<WorkOrder>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<WorkOrderRouting>> GetWorkOrderRoutingsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<WorkOrderRouting>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Customer>> GetCustomersAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Customer>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Department>> GetDepartmentsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Department>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<EmailAddress>> GetEmailAddresssAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<EmailAddress>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Employee>> GetEmployeesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Employee>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<EmployeeDepartmentHistory>> GetEmployeeDepartmentHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<EmployeeDepartmentHistory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<EmployeePayHistory>> GetEmployeePayHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<EmployeePayHistory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Illustration>> GetIllustrationsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Illustration>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<JobCandidate>> GetJobCandidatesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<JobCandidate>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Location>> GetLocationsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Location>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Password>> GetPasswordsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Password>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Person>> GetPersonsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Person>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<PersonCreditCard>> GetPersonCreditCardsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<PersonCreditCard>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<PersonPhone>> GetPersonPhonesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<PersonPhone>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<PhoneNumberType>> GetPhoneNumberTypesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<PhoneNumberType>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Product>> GetProductsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Product>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductCategory>> GetProductCategoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductCategory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductCostHistory>> GetProductCostHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductCostHistory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductDescription>> GetProductDescriptionsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductDescription>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductInventory>> GetProductInventoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductInventory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductListPriceHistory>> GetProductListPriceHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductListPriceHistory>(cancellationToken).ConfigureAwait (false);

        public async Task<IEnumerable<ProductModel>> GetProductModelsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductModel>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductModelIllustration>> GetProductModelIllustrationsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductModelIllustration>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductModelProductDescriptionCulture>> GetProductModelProductDescriptionCulturesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductModelProductDescriptionCulture>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductPhoto>> GetProductPhotosAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductPhoto>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductProductPhoto>> GetProductProductPhotosAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductProductPhoto>(cancellationToken).ConfigureAwait(false);    

        public async Task<IEnumerable<ProductReview>> GetProductReviewsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductReview>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductSubcategory>> GetProductSubcategorAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductSubcategory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ProductVendor>> GetProductVendorsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ProductVendor>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<PurchaseOrderDetail>> GetPurchaseOrderDetailsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<PurchaseOrderDetail>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<PurchaseOrderHeader>> GetPurchaseOrderHeadersAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<PurchaseOrderHeader>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesOrderDetail>> GetSalesOrderDetailsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesOrderDetail>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesOrderHeader>> GetSalesOrderHeadersAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesOrderHeader>(cancellationToken).ConfigureAwait (false);

        public async Task<IEnumerable<SalesOrderHeaderSalesReason>> salesOrderHeaderSalesReasonsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesOrderHeaderSalesReason>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesPerson>> GetSalesPersonsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesPerson>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesPersonQuotaHistory>> SalesPersonQuotaHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesPersonQuotaHistory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesReason>> GetSalesReasonsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesReason>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesTaxRate>> GetSalesTaxRatesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesTaxRate>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesTerritory>> GetSalesTerritoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesTerritory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SalesTerritoryHistory>> GetSalesTerritoryHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SalesTerritoryHistory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ScrapReason>> GetScrapReasonsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ScrapReason>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Shift>> GetShiftsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Shift>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ShipMethod>> GetShipMethodsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ShipMethod>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<ShoppingCartItem>> GetShoppingCartItemsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<ShoppingCartItem>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SpecialOffer>> GetSpecialOffersAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SpecialOffer>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<SpecialOfferProduct>> GetSpecialOfferProductsAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<SpecialOfferProduct>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<StateProvince>> GetStateProvincesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<StateProvince>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<Store>> GetStoresAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<Store>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<TransactionHistory>> GetTransactionHistoriesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<TransactionHistory>(cancellationToken).ConfigureAwait(false);

        public async Task<IEnumerable<TransactionHistoryArchive>> GetTransactionHistoryArchivesAsync(CancellationToken cancellationToken)
            => await GetListDataAsync<TransactionHistoryArchive>(cancellationToken).ConfigureAwait(false);

    }
}
