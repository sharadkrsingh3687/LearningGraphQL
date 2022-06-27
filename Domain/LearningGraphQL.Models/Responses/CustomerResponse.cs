
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Current customer information. Also see the Person and Store tables.
    /// </summary>
    public partial class CustomerResponse
    {
        public CustomerResponse()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeaderResponse>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public int CustomerId { get; set; }
        /// <summary>
        /// Foreign key to Person.BusinessEntityID
        /// </summary>
        public int? PersonId { get; set; }
        /// <summary>
        /// Foreign key to Store.BusinessEntityID
        /// </summary>
        public int? StoreId { get; set; }
        /// <summary>
        /// ID of the territory in which the customer is located. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        public int? TerritoryId { get; set; }
        /// <summary>
        /// Unique number identifying the customer assigned by the accounting system.
        /// </summary>
        public string AccountNumber { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual PersonResponse Person { get; set; }
        public virtual StoreResponse Store { get; set; }
        public virtual SalesTerritoryResponse Territory { get; set; }
        public virtual ICollection<SalesOrderHeaderResponse> SalesOrderHeader { get; set; }
    }
}