﻿




namespace Learning.GraphQL.Server.Models
{
    /// <summary>
    /// Type of phone number of a person.
    /// </summary>
    public partial class PhoneNumberType
    {
        public PhoneNumberType()
        {
            PersonPhone = new HashSet<PersonPhone>();
        }

        /// <summary>
        /// Primary key for telephone number type records.
        /// </summary>
        public int PhoneNumberTypeId { get; set; }
        /// <summary>
        /// Name of the telephone number type
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<PersonPhone> PersonPhone { get; set; }
    }
}