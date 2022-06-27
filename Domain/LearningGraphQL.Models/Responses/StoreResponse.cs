﻿
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Customers (resellers) of Adventure Works products.
    /// </summary>
    public partial class StoreResponse
    {
        public StoreResponse()
        {
            Customer = new HashSet<CustomerResponse>();
        }

        /// <summary>
        /// Primary key. Foreign key to Customer.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }
        /// <summary>
        /// Name of the store.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ID of the sales person assigned to the customer. Foreign key to SalesPerson.BusinessEntityID.
        /// </summary>
        public int? SalesPersonId { get; set; }
        /// <summary>
        /// Demographic informationg about the store such as the number of employees, annual sales and store type.
        /// </summary>
        public string Demographics { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual BusinessEntityResponse BusinessEntity { get; set; }
        public virtual SalesPersonResponse SalesPerson { get; set; }
        public virtual ICollection<CustomerResponse> Customer { get; set; }
    }
}