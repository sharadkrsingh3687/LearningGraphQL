
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Cross-reference table mapping ISO currency codes to a country or region.
    /// </summary>
    public partial class CountryRegionCurrencyResponse
    {
        /// <summary>
        /// ISO code for countries and regions. Foreign key to CountryRegion.CountryRegionCode.
        /// </summary>
        public string CountryRegionCode { get; set; }
        /// <summary>
        /// ISO standard currency code. Foreign key to Currency.CurrencyCode.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegionResponse CountryRegionCodeNavigation { get; set; }
        public virtual CurrencyResponse CurrencyCodeNavigation { get; set; }
    }
}