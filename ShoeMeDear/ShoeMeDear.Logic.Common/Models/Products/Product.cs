namespace ShoeMeDear.Logic.Common.Models.Products
{
    /// <summary>
    /// Model for Product entity is used in BL
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Unique identifier of concrete Product in BL.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Unique name of concrete Product in BL.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product picture path.
        /// </summary>
        public string PicturePath { get; set; } // Возможно придется сделать модельку для картинок

        /// <summary>
        /// Defines the Product description
        /// </summary>
        public string Description { get; set; }
    }
}
