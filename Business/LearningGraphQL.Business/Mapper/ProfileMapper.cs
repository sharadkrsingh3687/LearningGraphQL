using AutoMapper;
using LearningGraphQL.Domain.Models.Entities;
using LearningGraphQL.Domain.Models.Responses;

namespace LearningGraphQL.Business.Mapper
{
    public class ProfileMapper: Profile
    {
        public ProfileMapper()
        {
            this.CreateMap<Address, AddressResponse>();
            this.CreateMap<AddressType, AddressTypeResponse>();
            this.CreateMap<AwbuildVersion, AwbuildVersionResponse>();
            this.CreateMap<BillOfMaterials, BillOfMaterialsResponse>();
            this.CreateMap<BusinessEntity, BusinessEntityResponse>();
            this.CreateMap<BusinessEntityAddress, BusinessEntityAddressResponse>();
            this.CreateMap<BusinessEntityAddressResponse, BusinessEntityAddressResponse>();
            this.CreateMap<BusinessEntityContact, BusinessEntityContactResponse>();
            this.CreateMap<ContactType, ContactTypeResponse>();
            this.CreateMap<CountryRegion, CountryRegionResponse>();
            this.CreateMap<CountryRegionCurrency, CountryRegionCurrencyResponse>();
            this.CreateMap<CreditCard, CreditCardResponse>();
            this.CreateMap<Culture, CultureResponse>();
            this.CreateMap<Currency, CurrencyResponse>();
            this.CreateMap<CurrencyRate, CurrencyRateResponse>();
            this.CreateMap<Customer, CustomerResponse>();
            this.CreateMap<Department, DepartmentResponse>();
            this.CreateMap<EmailAddress, EmailAddressResponse>();
            this.CreateMap<Employee, EmployeeResponse>();
            this.CreateMap<EmployeeDepartmentHistory, EmployeeDepartmentHistoryResponse>();
            this.CreateMap<EmployeePayHistory, EmployeePayHistoryResponse>();
            this.CreateMap<Illustration, IllustrationResponse>();
            this.CreateMap<JobCandidate, JobCandidateResponse>();
            this.CreateMap<Location, LocationResponse>();
            this.CreateMap<Password, PasswordResponse>();
            this.CreateMap<Person, PersonResponse>();
            this.CreateMap<PersonCreditCard, PersonCreditCardResponse>();
            this.CreateMap<PersonPhone, PersonPhoneResponse>();
            this.CreateMap<PhoneNumberType, PhoneNumberTypeResponse>();
            this.CreateMap<Product, ProductResponse>();
            this.CreateMap<ProductCategory, ProductCategoryResponse>();
            this.CreateMap<ProductCostHistory, ProductCostHistoryResponse>();
            this.CreateMap<ProductDescription, ProductDescriptionResponse>();
            this.CreateMap<ProductInventory, ProductInventoryResponse>();
            this.CreateMap<ProductListPriceHistory, ProductListPriceHistoryResponse>();
            this.CreateMap<ProductModel, ProductModelResponse>();
            this.CreateMap<ProductModelIllustration, ProductModelIllustrationResponse>();
            this.CreateMap<ProductModelProductDescriptionCulture, ProductModelProductDescriptionCultureResponse>();
            this.CreateMap<ProductPhoto, ProductPhotoResponse>();
            this.CreateMap<ProductProductPhoto, ProductProductPhotoResponse>();
            this.CreateMap<ProductReview, ProductReviewResponse>();
            this.CreateMap<ProductSubcategory, ProductSubcategoryResponse>();
            this.CreateMap<ProductVendor, ProductVendorResponse>();
            this.CreateMap<PurchaseOrderDetail, PurchaseOrderDetailResponse>();
            this.CreateMap<PurchaseOrderHeader, PurchaseOrderHeaderResponse>();
            this.CreateMap<SalesOrderDetail, SalesOrderDetailResponse>();
            this.CreateMap<SalesOrderHeader, SalesOrderHeaderResponse>();
            this.CreateMap<SalesOrderHeaderSalesReason, SalesOrderHeaderSalesReasonResponse>();
            this.CreateMap<SalesPerson, SalesPersonResponse>();
            this.CreateMap<SalesPersonQuotaHistory, SalesPersonQuotaHistoryResponse>();
            this.CreateMap<SalesReason, SalesReasonResponse>();
            this.CreateMap<SalesTaxRate, SalesTaxRateResponse>();
            this.CreateMap<SalesTerritory, SalesTerritoryResponse>();
            this.CreateMap<SalesTerritoryHistory, SalesTerritoryHistoryResponse>();
            this.CreateMap<ScrapReason, ScrapReasonResponse>();
            this.CreateMap<Shift, ShiftResponse>();
            this.CreateMap<ShipMethod, ShipMethodResponse>();
            this.CreateMap<ShoppingCartItem, ShoppingCartItemResponse>();
            this.CreateMap<SpecialOffer, SpecialOfferResponse>();
            this.CreateMap<SpecialOfferProduct, SpecialOfferProductResponse>();
            this.CreateMap<StateProvince, StateProvinceResponse>();
            this.CreateMap<Store, StoreResponse>();
            this.CreateMap<TransactionHistory, TransactionHistoryResponse>();
            this.CreateMap<TransactionHistoryArchive, TransactionHistoryArchiveResponse>();
            this.CreateMap<UnitMeasure, UnitMeasureResponse>();
            this.CreateMap<Vendor, VendorResponse>();
            this.CreateMap<WorkOrder, WorkOrderResponse>();
            this.CreateMap<WorkOrderRouting, WorkOrderRoutingResponse>();
        }
    }
}
