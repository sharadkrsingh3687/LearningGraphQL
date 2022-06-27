
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Source of the ID that connects vendors, customers, and employees with address and contact information.
    /// </summary>
    public partial class BusinessEntityResponse
    {
        public BusinessEntityResponse()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddressResponse>();
            BusinessEntityContact = new HashSet<BusinessEntityContactResponse>();
        }

        /// <summary>
        /// Primary key for all customers, vendors, and employees.
        /// </summary>
        public int BusinessEntityId { get; set; }
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
        public virtual VendorResponse Vendor { get; set; }
        public virtual ICollection<BusinessEntityAddressResponse> BusinessEntityAddress { get; set; }
        public virtual ICollection<BusinessEntityContactResponse> BusinessEntityContact { get; set; }
    }
}