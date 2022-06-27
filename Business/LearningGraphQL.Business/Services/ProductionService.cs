using LearningGraphQL.Business.Contract.Services;
using AutoMapper;
using LearningGraphQL.Persist.Contract;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Domain.Models.Entities;

namespace LearningGraphQL.Business.Services
{
    public class ProductionService : IProductionService
    {
        private readonly IMapper _mapper;
        private readonly IAdventureWorksDataProvider _dataProvider;

        public ProductionService(IMapper mapper, IAdventureWorksDataProvider provider)
        {
            this._mapper = mapper;
            this._dataProvider = provider;
        }

        public async Task<IEnumerable<BillOfMaterialsResponse>> GetBillOfMaterialsListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetBillOfMaterialsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<BillOfMaterials>, IEnumerable<BillOfMaterialsResponse>>(resultSet);
        }

        public async Task<IEnumerable<CultureResponse>> GetCultureListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCulturesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Culture>, IEnumerable<CultureResponse>>(resultSet); 
        }

        public async Task<IEnumerable<IllustrationResponse>> GetIllustrationListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetIllustrationsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Illustration>, IEnumerable<IllustrationResponse>>(resultSet);
        }

        public async Task<IEnumerable<LocationResponse>> GetLocationListAsync(CancellationToken cancellationToken)
        {
           var resultSet = await _dataProvider.GetLocationsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Location>, IEnumerable<LocationResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductCategoryResponse>> GetProductCategoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductCategoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductCategory>, IEnumerable<ProductCategoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductCostHistoryResponse>> GetProductCostHistoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet  = await _dataProvider.GetProductCostHistoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductCostHistory>, IEnumerable<ProductCostHistoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductDescriptionResponse>> GetProductDescriptionListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductDescriptionsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductDescription>, IEnumerable<ProductDescriptionResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductInventoryResponse>> GetProductInventoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductInventoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductInventory>, IEnumerable<ProductInventoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductResponse>> GetProductListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Product>, IEnumerable<ProductResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductListPriceHistoryResponse>> GetProductListPriceHistoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductListPriceHistoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductListPriceHistory>, IEnumerable<ProductListPriceHistoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductModelIllustrationResponse>> GetProductModelIllustrationListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductModelIllustrationsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductModelIllustration>, IEnumerable<ProductModelIllustrationResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductModelResponse>> GetProductModelListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductModelsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductModel>, IEnumerable<ProductModelResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductModelProductDescriptionCultureResponse>> GetProductModelProductDescriptionCultureListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductModelProductDescriptionCulturesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductModelProductDescriptionCulture>, IEnumerable<ProductModelProductDescriptionCultureResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductPhotoResponse>> GetProductPhotoListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductPhotosAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductPhoto>, IEnumerable<ProductPhotoResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductProductPhotoResponse>> GetProductProductPhotoListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductProductPhotosAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductProductPhoto>, IEnumerable<ProductProductPhotoResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductReviewResponse>> GetProductReviewListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductReviewsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductReview>, IEnumerable<ProductReviewResponse>>(resultSet);
        }

        public async Task<IEnumerable<ProductSubcategoryResponse>> GetProductSubcategoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductSubcategorAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductSubcategory>, IEnumerable<ProductSubcategoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<ScrapReasonResponse>> GetScrapReasonListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetScrapReasonsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ScrapReason>, IEnumerable<ScrapReasonResponse>>(resultSet);
        }

        public async Task<IEnumerable<TransactionHistoryArchiveResponse>> GetTransactionHistoryArchiveListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetTransactionHistoryArchivesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<TransactionHistoryArchive>, IEnumerable<TransactionHistoryArchiveResponse>>(resultSet);
        }

        public async Task<IEnumerable<TransactionHistoryResponse>> GetTransactionHistoryListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetTransactionHistoriesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<TransactionHistory>, IEnumerable<TransactionHistoryResponse>>(resultSet);
        }

        public async Task<IEnumerable<UnitMeasureResponse>> GetUnitMeasureListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetUnitMeasuresAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<UnitMeasure>, IEnumerable<UnitMeasureResponse>>(resultSet);
        }

        public async Task<IEnumerable<WorkOrderResponse>> GetWorkOrderListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetWorkOrdersAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<WorkOrder>, IEnumerable<WorkOrderResponse>>(resultSet);
        }

        public async Task<IEnumerable<WorkOrderRoutingResponse>> GetWorkOrderRoutingListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetWorkOrderRoutingsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<WorkOrderRouting>, IEnumerable<WorkOrderRoutingResponse>>(resultSet);
        }
    }
}
