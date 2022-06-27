using LearningGraphQL.Domain.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningGraphQL.Business.Contract.Services
{
    public interface IPersonService
    {
        Task<IEnumerable<AddressResponse>> GetAddressListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<AddressTypeResponse>> GetAddressTypeListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<BusinessEntityResponse>> GetBusinessEntityListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<BusinessEntityAddressResponse>> GetBusinessEntityAddressListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<BusinessEntityContactResponse>> GetBusinessEntityContactListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<ContactTypeResponse>> GetContactTypeListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CountryRegionResponse>> GetCountryRegionListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<CountryRegionCurrencyResponse>> GetCountryRegionCurrencyListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<EmailAddressResponse>> GetEmailAddressListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PasswordResponse>> GetPasswordListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PersonResponse>> GetPersonListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PersonPhoneResponse>> GetPersonPhoneListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<PhoneNumberTypeResponse>> GetPhoneNumberTypeListAsync(CancellationToken cancellationToken);
        Task<IEnumerable<StateProvinceResponse>> GetStateProvinceListAsync(CancellationToken cancellationToken);
    }
}
