
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Unit of measure lookup table.
    /// </summary>
    public partial class UnitMeasureResponse
    {
        public UnitMeasureResponse()
        {
            BillOfMaterials = new HashSet<BillOfMaterialsResponse>();
            ProductSizeUnitMeasureCodeNavigation = new HashSet<ProductResponse>();
            ProductVendor = new HashSet<ProductVendorResponse>();
            ProductWeightUnitMeasureCodeNavigation = new HashSet<ProductResponse>();
        }

        /// <summary>
        /// Primary key.
        /// </summary>
        public string UnitMeasureCode { get; set; }
        /// <summary>
        /// Unit of measure description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<BillOfMaterialsResponse> BillOfMaterials { get; set; }
        public virtual ICollection<ProductResponse> ProductSizeUnitMeasureCodeNavigation { get; set; }
        public virtual ICollection<ProductVendorResponse> ProductVendor { get; set; }
        public virtual ICollection<ProductResponse> ProductWeightUnitMeasureCodeNavigation { get; set; }
    }
}