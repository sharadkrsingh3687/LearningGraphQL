
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Lookup table containing the ISO standard codes for countries and regions.
    /// </summary>
    public partial class CountryRegionResponse
    {
        public CountryRegionResponse()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrencyResponse>();
            SalesTerritory = new HashSet<SalesTerritoryResponse>();
            StateProvince = new HashSet<StateProvinceResponse>();
        }

        /// <summary>
        /// ISO standard code for countries and regions.
        /// </summary>
        public string CountryRegionCode { get; set; }
        /// <summary>
        /// Country or region name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrencyResponse> CountryRegionCurrency { get; set; }
        public virtual ICollection<SalesTerritoryResponse> SalesTerritory { get; set; }
        public virtual ICollection<StateProvinceResponse> StateProvince { get; set; }
    }
}