
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Lookup table containing standard ISO currencies.
    /// </summary>
    public partial class CurrencyResponse
    {
        public CurrencyResponse()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrencyResponse>();
            CurrencyRateFromCurrencyCodeNavigation = new HashSet<CurrencyRateResponse>();
            CurrencyRateToCurrencyCodeNavigation = new HashSet<CurrencyRateResponse>();
        }

        /// <summary>
        /// The ISO code for the Currency.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Currency name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrencyResponse> CountryRegionCurrency { get; set; }
        public virtual ICollection<CurrencyRateResponse> CurrencyRateFromCurrencyCodeNavigation { get; set; }
        public virtual ICollection<CurrencyRateResponse> CurrencyRateToCurrencyCodeNavigation { get; set; }
    }
}