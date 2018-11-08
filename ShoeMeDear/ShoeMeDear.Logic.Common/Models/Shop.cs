namespace ShoeMeDear.Logic.Common.Models
{
    /// <summary>
    /// Represents a data of included into website shop, store or any marketplace.
    /// </summary>
    public class Shop
    {
        /// <summary>
        /// Gets or sets marketplace ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets marketplace name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the reference of a marketplace.
        /// </summary>
        public string Reference { get; set; }
    }
}