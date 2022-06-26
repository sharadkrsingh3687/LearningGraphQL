using LearningGraphQL.Domain.Models.Entities;
using LearningGraphQL.Persist.Contract;
using Microsoft.EntityFrameworkCore;

namespace LearningGraphQL.Persist
{
    public class AdventureWorksDbContext : DbContext, IAdventureWorksDbContext
    {
        public DbSet<Address> Address => Set<Address>();
        public DbSet<AddressType> AddressType => Set<AddressType>();
        public DbSet<AwbuildVersion> AwbuildVersion => Set<AwbuildVersion>();
        public DbSet<BillOfMaterials> BillOfMaterials => Set<BillOfMaterials>();
        public DbSet<BusinessEntity> BusinessEntity => Set<BusinessEntity>();
        public DbSet<BusinessEntityAddress> BusinessEntityAddress => Set<BusinessEntityAddress>();
        public DbSet<BusinessEntityContact> BusinessEntityContact => Set<BusinessEntityContact>();
        public DbSet<ContactType> ContactType => Set<ContactType>();
        public DbSet<CountryRegion> CountryRegion => Set<CountryRegion>();
        public DbSet<CountryRegionCurrency> CountryRegionCurrency => Set<CountryRegionCurrency>();
        public DbSet<CreditCard> CreditCard => Set<CreditCard>();
        public DbSet<Culture> Culture => Set<Culture>();
        public DbSet<Currency> Currency => Set<Currency>();
        public DbSet<CurrencyRate> CurrencyRate => Set<CurrencyRate>();
        public DbSet<Customer> Customer => Set<Customer>();
        public DbSet<Department> Department => Set<Department>();
        public DbSet<EmailAddress> EmailAddress => Set<EmailAddress>();
        public DbSet<Employee> Employee => Set<Employee>();
        public DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory => Set<EmployeeDepartmentHistory>();
        public DbSet<EmployeePayHistory> EmployeePayHistory => Set<EmployeePayHistory>();
        public DbSet<Illustration> Illustration => Set<Illustration>();
        public DbSet<JobCandidate> JobCandidate => Set<JobCandidate>();
        public DbSet<Location> Location => Set<Location>();
        public DbSet<Password> Password => Set<Password>();
        public DbSet<Person> Person => Set<Person>();
        public DbSet<PersonCreditCard> PersonCreditCard => Set<PersonCreditCard>();
        public DbSet<PersonPhone> PersonPhone => Set<PersonPhone>();
        public DbSet<ProductCategory> ProductCategory => Set<ProductCategory>();
        public DbSet<ProductCostHistory> ProductCostHistory => Set<ProductCostHistory>();
        public DbSet<ProductDescription> ProductDescription => Set<ProductDescription>();
        public DbSet<ProductInventory> ProductInventory => Set<ProductInventory>();
        public DbSet<ProductListPriceHistory> ProductListPriceHistory => Set<ProductListPriceHistory>();
        public DbSet<ProductModel> ProductModel => Set<ProductModel>();
        public DbSet<ProductModelIllustration> ProductModelIllustration => Set<ProductModelIllustration>();
        public DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture => Set<ProductModelProductDescriptionCulture>();
        public DbSet<ProductPhoto> ProductPhoto => Set<ProductPhoto>();
        public DbSet<ProductProductPhoto> ProductProductPhoto => Set<ProductProductPhoto>();
        public DbSet<ProductReview> ProductReview => Set<ProductReview>();
        public DbSet<ProductSubcategory> ProductSubcategory => Set<ProductSubcategory>();
        public DbSet<ProductVendor> ProductVendor => Set<ProductVendor>();
        public DbSet<PurchaseOrderDetail> PurchaseOrderDetail => Set<PurchaseOrderDetail>();
        public DbSet<PurchaseOrderHeader> PurchaseOrderHeader => Set<PurchaseOrderHeader>();
        public DbSet<SalesOrderDetail> SalesOrderDetail => Set<SalesOrderDetail>();
        public DbSet<SalesOrderHeader> SalesOrderHeader => Set<SalesOrderHeader>();
        public DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason => Set<SalesOrderHeaderSalesReason>();
        public DbSet<SalesPerson> SalesPerson => Set<SalesPerson>();
        public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory => Set<SalesPersonQuotaHistory>();
        public DbSet<SalesReason> SalesReason => Set<SalesReason>();
        public DbSet<SalesTaxRate> SalesTaxRate => Set<SalesTaxRate>();
        public DbSet<SalesTerritory> SalesTerritory => Set<SalesTerritory>();
        public DbSet<SalesTerritoryHistory> SalesTerritoryHistory => Set<SalesTerritoryHistory>();
        public DbSet<ScrapReason> ScrapReason => Set<ScrapReason>();
        public DbSet<ShipMethod> ShipMethod => Set<ShipMethod>();
        public DbSet<ShoppingCartItem> ShoppingCartItem => Set<ShoppingCartItem>();
        public DbSet<SpecialOffer> SpecialOffer => Set<SpecialOffer>();
        public DbSet<SpecialOfferProduct> SpecialOfferProduct => Set<SpecialOfferProduct>();
        public DbSet<StateProvince> StateProvince => Set<StateProvince>();
        public DbSet<Store> Store => Set<Store>();
        public DbSet<TransactionHistory> TransactionHistory => Set<TransactionHistory>();
        public DbSet<TransactionHistoryArchive> TransactionHistoryArchive => Set<TransactionHistoryArchive>();
        public DbSet<UnitMeasure> UnitMeasure => Set<UnitMeasure>();
        public DbSet<Vendor> Vendor => Set<Vendor>();
        public DbSet<WorkOrder> WorkOrder => Set<WorkOrder>();
        public DbSet<WorkOrderRouting> WorkOrderRouting => Set<WorkOrderRouting>();
    }
}
