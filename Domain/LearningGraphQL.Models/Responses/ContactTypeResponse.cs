
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Lookup table containing the types of business entity contacts.
    /// </summary>
    public partial class ContactTypeResponse
    {
        public ContactTypeResponse()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContactResponse>();
        }

        /// <summary>
        /// Primary key for ContactType records.
        /// </summary>
        public int ContactTypeId { get; set; }
        /// <summary>
        /// Contact type description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BusinessEntityContactResponse> BusinessEntityContact { get; set; }
    }
}