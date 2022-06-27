




namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Lookup table of customer purchase reasons.
    /// </summary>
    public partial class SalesReasonResponse
    {
        public SalesReasonResponse()
        {
            SalesOrderHeaderSalesReason = new HashSet<SalesOrderHeaderSalesReasonResponse>();
        }

        /// <summary>
        /// Primary key for SalesReason records.
        /// </summary>
        public int SalesReasonId { get; set; }
        /// <summary>
        /// Sales reason description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Category the sales reason belongs to.
        /// </summary>
        public string ReasonType { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<SalesOrderHeaderSalesReasonResponse> SalesOrderHeaderSalesReason { get; set; }
    }
}