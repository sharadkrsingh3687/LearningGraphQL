




namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Manufacturing failure reasons lookup table.
    /// </summary>
    public partial class ScrapReasonResponse
    {
        public ScrapReasonResponse()
        {
            WorkOrder = new HashSet<WorkOrderResponse>();
        }

        /// <summary>
        /// Primary key for ScrapReason records.
        /// </summary>
        public short ScrapReasonId { get; set; }
        /// <summary>
        /// Failure description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<WorkOrderResponse> WorkOrder { get; set; }
    }
}