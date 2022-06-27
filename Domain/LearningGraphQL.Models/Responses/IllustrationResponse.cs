
namespace LearningGraphQL.Domain.Models.Responses
{
    /// <summary>
    /// Bicycle assembly diagrams.
    /// </summary>
    public partial class IllustrationResponse
    {
        public IllustrationResponse()
        {
            ProductModelIllustration = new HashSet<ProductModelIllustrationResponse>();
        }

        /// <summary>
        /// Primary key for Illustration records.
        /// </summary>
        public int IllustrationId { get; set; }
        /// <summary>
        /// Illustrations used in manufacturing instructions. Stored as XML.
        /// </summary>
        public string Diagram { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<ProductModelIllustrationResponse> ProductModelIllustration { get; set; }
    }
}