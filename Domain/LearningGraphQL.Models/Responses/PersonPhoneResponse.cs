




namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Telephone number and type of a person.
    /// </summary>
    public partial class PersonPhoneResponse
    {
        /// <summary>
        /// Business entity identification number. Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }
        /// <summary>
        /// Telephone number identification number.
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Kind of phone number. Foreign key to PhoneNumberType.PhoneNumberTypeID.
        /// </summary>
        public int PhoneNumberTypeId { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual PersonResponse BusinessEntity { get; set; }
        public virtual PhoneNumberTypeResponse PhoneNumberType { get; set; }
    }
}