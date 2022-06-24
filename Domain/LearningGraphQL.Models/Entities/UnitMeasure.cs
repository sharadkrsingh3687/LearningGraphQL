﻿




namespace LearningGraphQL.Domain.Models.Entities
{
    /// <summary>
    /// Unit of measure lookup table.
    /// </summary>
    public partial class UnitMeasure
    {
        public UnitMeasure()
        {
            BillOfMaterials = new HashSet<BillOfMaterials>();
            ProductSizeUnitMeasureCodeNavigation = new HashSet<Product>();
            ProductVendor = new HashSet<ProductVendor>();
            ProductWeightUnitMeasureCodeNavigation = new HashSet<Product>();
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

        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual ICollection<Product> ProductSizeUnitMeasureCodeNavigation { get; set; }
        public virtual ICollection<ProductVendor> ProductVendor { get; set; }
        public virtual ICollection<Product> ProductWeightUnitMeasureCodeNavigation { get; set; }
    }
}