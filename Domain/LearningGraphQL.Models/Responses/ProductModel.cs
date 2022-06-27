
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Product model classification.
    /// </summary>
    public partial class ProductModelResponse
    {
        public ProductModelResponse()
        {
            Product = new HashSet<ProductResponse>();
            ProductModelIllustration = new HashSet<ProductModelIllustrationResponse>();
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCultureResponse>();
        }

        /// <summary>
        /// Primary key for ProductModel records.
        /// </summary>
        public int ProductModelId { get; set; }
        /// <summary>
        /// Product model description.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Detailed product catalog information in xml format.
        /// </summary>
        public string CatalogDescription { get; set; }
        /// <summary>
        /// Manufacturing instructions in xml format.
        /// </summary>
        public string Instructions { get; set; }
        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        public Guid Rowguid { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductResponse> Product { get; set; }
        public virtual ICollection<ProductModelIllustrationResponse> ProductModelIllustration { get; set; }
        public virtual ICollection<ProductModelProductDescriptionCultureResponse> ProductModelProductDescriptionCulture { get; set; }
    }
}