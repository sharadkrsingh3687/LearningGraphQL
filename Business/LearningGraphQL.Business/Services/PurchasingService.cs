using AutoMapper;
using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Domain.Models.Entities;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Persist.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGraphQL.Business.Services
{
    public class PurchasingService : IPurchasingService
    {
        private readonly IMapper _mapper;
        private readonly IAdventureWorksDataProvider _dataProvider;
        public PurchasingService(IMapper mapper, IAdventureWorksDataProvider provider)
        {
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._dataProvider = provider;
        }

        public async Task<IEnumerable<ProductVendorResponse>> GetProductVendorListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetProductVendorsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ProductVendor>, IEnumerable<ProductVendorResponse>>(resultSet);
        }

        public async Task<IEnumerable<PurchaseOrderDetailResponse>> GetPurchaseOrderDetailListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPurchaseOrderDetailsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<PurchaseOrderDetail>, IEnumerable<PurchaseOrderDetailResponse>>(resultSet);
        }

        public async Task<IEnumerable<PurchaseOrderHeaderResponse>> GetPurchaseOrderHeaderListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPurchaseOrderHeadersAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<PurchaseOrderHeader>, IEnumerable<PurchaseOrderHeaderResponse>>(resultSet);
        }

        public async Task<IEnumerable<ShipMethodResponse>> GetShipMethodListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetShipMethodsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ShipMethod>, IEnumerable<ShipMethodResponse>>(resultSet);
        }

        public async Task<IEnumerable<VendorResponse>> GetVendorListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetVendorsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Vendor>, IEnumerable<VendorResponse>>(resultSet);
        }
    }
}
