
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Product images.
    /// </summary>
    public partial class ProductPhotoResponse
    {
        public ProductPhotoResponse()
        {
            ProductProductPhoto = new HashSet<ProductProductPhotoResponse>();
        }

        /// <summary>
        /// Primary key for ProductPhoto records.
        /// </summary>
        public int ProductPhotoId { get; set; }
        /// <summary>
        /// Small image of the product.
        /// </summary>
        public byte[] ThumbNailPhoto { get; set; }
        /// <summary>
        /// Small image file name.
        /// </summary>
        public string ThumbnailPhotoFileName { get; set; }
        /// <summary>
        /// Large image of the product.
        /// </summary>
        public byte[] LargePhoto { get; set; }
        /// <summary>
        /// Large image file name.
        /// </summary>
        public string LargePhotoFileName { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductProductPhotoResponse> ProductProductPhoto { get; set; }
    }
}