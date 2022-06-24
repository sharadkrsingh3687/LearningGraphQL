using Microsoft.EntityFrameworkCore;
using LearningGraphQL.Domain.Models.Entities;

namespace LearningGraphQL.Persist.Contract
{
    public interface IAdventureWorksDbContext
    {
        DbSet<Address> Address { get; }
        DbSet<AddressType> AddressType { get; }
        DbSet<AwbuildVersion> AwbuildVersion { get; }
        DbSet<BillOfMaterials> BillOfMaterials { get; }
        DbSet<BusinessEntity> BusinessEntity { get; }
        DbSet<BusinessEntityAddress> BusinessEntityAddress { get; }
        DbSet<BusinessEntityContact> BusinessEntityContact { get; }
        DbSet<ContactType> ContactType { get; }
        DbSet<CountryRegion> CountryRegion { get; }
        DbSet<CountryRegionCurrency> CountryRegionCurrency { get; }
        DbSet<CreditCard> CreditCard { get; }
        DbSet<Culture> Culture { get; }
        DbSet<Currency> Currency { get; }
        DbSet<Customer> Customer { get; }
        DbSet<Department> Department { get; }
        DbSet<EmailAddress> EmailAddress { get; }
        DbSet<Employee> Employee { get; }
        DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; }
        DbSet<EmployeePayHistory> EmployeePayHistory { get; }
        DbSet<Illustration> Illustration { get; }
        DbSet<JobCandidate> JobCandidate { get; }
        DbSet<Location> Location { get; }
        DbSet<Password> Password { get; }
        DbSet<Person> Person { get; }
        DbSet<PersonCreditCard> PersonCreditCard { get; }
        DbSet<PersonPhone> PersonPhone { get; }
        DbSet<ProductCategory> ProductCategory { get; }
        DbSet<ProductCostHistory> ProductCostHistory { get; }
        DbSet<ProductDescription> ProductDescription { get; }
        DbSet<ProductInventory> ProductInventory { get; }
        DbSet<ProductListPriceHistory> ProductListPriceHistory { get; }
        DbSet<ProductModel> ProductModel { get; }
        DbSet<ProductModelIllustration> ProductModelIllustration { get; }
        DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; }
        DbSet<ProductPhoto> ProductPhoto { get; }
        DbSet<ProductProductPhoto> ProductProductPhoto { get; }
        DbSet<ProductReview> ProductReview { get; }
        DbSet<ProductSubcategory> ProductSubcategory { get; }
        DbSet<ProductVendor> ProductVendor { get; }
        DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; }
        DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; }
        DbSet<SalesOrderDetail> SalesOrderDetail { get; }
        DbSet<SalesOrderHeader> SalesOrderHeader { get; }
        DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; }
        DbSet<SalesPerson> SalesPerson { get; }
        DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; }
        DbSet<SalesReason> SalesReason { get; }
        DbSet<SalesTaxRate> SalesTaxRate { get; }
        DbSet<SalesTerritory> SalesTerritory { get; }
        DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; }
        DbSet<ScrapReason> ScrapReason { get; }
        DbSet<ShipMethod> ShipMethod { get; }
        DbSet<ShoppingCartItem> ShoppingCartItem { get; }
        DbSet<SpecialOffer> SpecialOffer { get; }
        DbSet<SpecialOfferProduct> SpecialOfferProduct { get; }
        DbSet<StateProvince> StateProvince { get; }
        DbSet<Store> Store { get; }
        DbSet<TransactionHistory> TransactionHistory { get; }
        DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; }
        DbSet<UnitMeasure> UnitMeasure { get; }
        DbSet<Vendor> Vendor { get; }
        DbSet<WorkOrder> WorkOrder { get; }
        DbSet<WorkOrderRouting> WorkOrderRouting { get; }
    }
}
