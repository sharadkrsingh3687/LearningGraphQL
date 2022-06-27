
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Cross-reference table mapping product descriptions and the language the description is written in.
    /// </summary>
    public partial class ProductModelProductDescriptionCultureResponse
    {
        /// <summary>
        /// Primary key. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        public int ProductModelId { get; set; }
        /// <summary>
        /// Primary key. Foreign key to ProductDescription.ProductDescriptionID.
        /// </summary>
        public int ProductDescriptionId { get; set; }
        /// <summary>
        /// Culture identification number. Foreign key to Culture.CultureID.
        /// </summary>
        public string CultureId { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual CultureResponse Culture { get; set; }
        public virtual ProductDescriptionResponse ProductDescription { get; set; }
        public virtual ProductModelResponse ProductModel { get; set; }
    }
}