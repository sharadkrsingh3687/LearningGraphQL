﻿
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// One way hashed authentication information
    /// </summary>
    public partial class PasswordResponse
    {
        public int BusinessEntityId { get; set; }
        /// <summary>
        /// Password for the e-mail account.
        /// </summary>
        public string PasswordHash { get; set; }
        /// <summary>
        /// Random value concatenated with the password string before the password is hashed.
        /// </summary>
        public string PasswordSalt { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual PersonResponse BusinessEntity { get; set; }
    }
}