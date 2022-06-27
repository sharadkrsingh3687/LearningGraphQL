
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Product inventory and manufacturing locations.
    /// </summary>
    public partial class LocationResponse
    {
        public LocationResponse()
        {
            ProductInventory = new HashSet<ProductInventoryResponse>();
            WorkOrderRouting = new HashSet<WorkOrderRoutingResponse>();
        }

        /// <summary>
        /// Primary key for Location records.
        /// </summary>
        public short LocationId { get; set; }
        /// <summary>
        /// Location description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Standard hourly cost of the manufacturing location.
        /// </summary>
        public decimal CostRate { get; set; }
        /// <summary>
        /// Work capacity (in hours) of the manufacturing location.
        /// </summary>
        public decimal Availability { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductInventoryResponse> ProductInventory { get; set; }
        public virtual ICollection<WorkOrderRoutingResponse> WorkOrderRouting { get; set; }
    }
}