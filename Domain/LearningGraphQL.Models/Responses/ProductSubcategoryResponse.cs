
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Product subcategories. See ProductCategory table.
    /// </summary>
    public partial class ProductSubcategoryResponse
    {
        public ProductSubcategoryResponse()
        {
            Product = new HashSet<ProductResponse>();
        }

        /// <summary>
        /// Primary key for ProductSubcategory records.
        /// </summary>
        public int ProductSubcategoryId { get; set; }
        /// <summary>
        /// Product category identification number. Foreign key to ProductCategory.ProductCategoryID.
        /// </summary>
        public int ProductCategoryId { get; set; }
        /// <summary>
        /// Subcategory description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ProductCategoryResponse ProductCategory { get; set; }
        public virtual ICollection<ProductResponse> Product { get; set; }
    }
}