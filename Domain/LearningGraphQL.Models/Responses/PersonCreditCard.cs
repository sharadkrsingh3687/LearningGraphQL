




namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Cross-reference table mapping people to their credit card information in the CreditCard table. 
    /// </summary>
    public partial class PersonCreditCardResponse
    {
        /// <summary>
        /// Business entity identification number. Foreign key to Person.BusinessEntityID.
        /// </summary>
        public int BusinessEntityId { get; set; }
        /// <summary>
        /// Credit card identification number. Foreign key to CreditCard.CreditCardID.
        /// </summary>
        public int CreditCardId { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual PersonResponse BusinessEntity { get; set; }
        public virtual CreditCardResponse CreditCard { get; set; }
    }
}