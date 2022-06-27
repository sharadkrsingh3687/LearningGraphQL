using LearningGraphQL.Business.Contract.Services;
using LearningGraphQL.Persist.Contract;
using AutoMapper;
using LearningGraphQL.Domain.Models.Responses;
using LearningGraphQL.Domain.Models.Entities;

namespace LearningGraphQL.Business.Services
{
    public class PersonService: IPersonService
    {
        private readonly IAdventureWorksDataProvider _dataProvider;
        private readonly IMapper _mapper;

        public PersonService(IMapper mapper, IAdventureWorksDataProvider provider)
        {
            this._dataProvider = provider;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<AddressResponse>> GetAddressListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetAddresssAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Address>, IEnumerable<AddressResponse>>(resultSet);
        }

        public async Task<IEnumerable<AddressTypeResponse>> GetAddressTypeListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetAddressTypesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<AddressType>, IEnumerable<AddressTypeResponse>>(resultSet); 
        }

        public async Task<IEnumerable<BusinessEntityAddressResponse>> GetBusinessEntityAddressListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetBusinessEntityAddresssAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<BusinessEntityAddress>, IEnumerable<BusinessEntityAddressResponse>>(resultSet);
        }

        public async Task<IEnumerable<BusinessEntityContactResponse>> GetBusinessEntityContactListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetBusinessEntityContactsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<BusinessEntityContact>, IEnumerable<BusinessEntityContactResponse>>(resultSet);
        }

        public async Task<IEnumerable<BusinessEntityResponse>> GetBusinessEntityListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetBusinessEntitiesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<BusinessEntity>, IEnumerable<BusinessEntityResponse>>(resultSet);
        }

        public async Task<IEnumerable<ContactTypeResponse>> GetContactTypeListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetContactTypesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<ContactType>, IEnumerable<ContactTypeResponse>>(resultSet); 
        }

        public async Task<IEnumerable<CountryRegionCurrencyResponse>> GetCountryRegionCurrencyListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCountryRegionCurrenciesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<CountryRegionCurrency>, IEnumerable<CountryRegionCurrencyResponse>>(resultSet);
        }

        public async Task<IEnumerable<CountryRegionResponse>> GetCountryRegionListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetCountryRegionsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<CountryRegion>, IEnumerable<CountryRegionResponse>>(resultSet); 
        }

        public async Task<IEnumerable<EmailAddressResponse>> GetEmailAddressListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetEmailAddresssAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<EmailAddress>, IEnumerable<EmailAddressResponse>>(resultSet);
        }

        public async Task<IEnumerable<PasswordResponse>> GetPasswordListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPasswordsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Password>, IEnumerable<PasswordResponse>>(resultSet);   
        }

        public async Task<IEnumerable<PersonResponse>> GetPersonListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPersonsAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<Person>, IEnumerable<PersonResponse>>(resultSet);
        }

        public async Task<IEnumerable<PersonPhoneResponse>> GetPersonPhoneListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPersonPhonesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<PersonPhone>, IEnumerable<PersonPhoneResponse>>(resultSet);
        }

        public async Task<IEnumerable<PhoneNumberTypeResponse>> GetPhoneNumberTypeListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetPhoneNumberTypesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<PhoneNumberType>, IEnumerable<PhoneNumberTypeResponse>>(resultSet);
        }

        public async Task<IEnumerable<StateProvinceResponse>> GetStateProvinceListAsync(CancellationToken cancellationToken)
        {
            var resultSet = await _dataProvider.GetStateProvincesAsync(cancellationToken).ConfigureAwait(false);
            return this._mapper.Map<IEnumerable<StateProvince>, IEnumerable<StateProvinceResponse>>(resultSet);
        }
    }
}
