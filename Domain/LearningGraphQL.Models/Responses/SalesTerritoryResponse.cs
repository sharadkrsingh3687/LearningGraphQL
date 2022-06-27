namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Sales territory lookup table.
    /// </summary>
    public partial class SalesTerritoryResponse
    {
        public SalesTerritoryResponse()
        {
            Customer = new HashSet<CustomerResponse>();
            SalesOrderHeader = new HashSet<SalesOrderHeaderResponse>();
            SalesPerson = new HashSet<SalesPersonResponse>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistoryResponse>();
            StateProvince = new HashSet<StateProvinceResponse>();
        }

        /// <summary>
        /// Primary key for SalesTerritory records.
        /// </summary>
        public int TerritoryId { get; set; }
        /// <summary>
        /// Sales territory description
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ISO standard country or region code. Foreign key to CountryRegion.CountryRegionCode. 
        /// </summary>
        public string CountryRegionCode { get; set; }
        /// <summary>
        /// Geographic area to which the sales territory belong.
        /// </summary>
        public string Group { get; set; }
        /// <summary>
        /// Sales in the territory year to date.
        /// </summary>
        public decimal SalesYtd { get; set; }
        /// <summary>
        /// Sales in the territory the previous year.
        /// </summary>
        public decimal SalesLastYear { get; set; }
        /// <summary>
        /// Business costs in the territory year to date.
        /// </summary>
        public decimal CostYtd { get; set; }
        /// <summary>
        /// Business costs in the territory the previous year.
        /// </summary>
        public decimal CostLastYear { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual CountryRegionResponse CountryRegionCodeNavigation { get; set; }
        public virtual ICollection<CustomerResponse> Customer { get; set; }
        public virtual ICollection<SalesOrderHeaderResponse> SalesOrderHeader { get; set; }
        public virtual ICollection<SalesPersonResponse> SalesPerson { get; set; }
        public virtual ICollection<SalesTerritoryHistoryResponse> SalesTerritoryHistory { get; set; }
        public virtual ICollection<StateProvinceResponse> StateProvince { get; set; }
    }
}