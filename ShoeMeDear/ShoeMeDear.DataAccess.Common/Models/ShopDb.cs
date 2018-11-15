using System.Collections.Generic;
using ShoeMeDear.DataAccess.Common.Models.Products;
using ShoeMeDear.DataAccess.Common.Models.Users;

namespace ShoeMeDear.DataAccess.Common.Models
{
    /// <summary>
    /// Saves and represents a data of included into this website shop, store or any marketplace.
    /// </summary>
    public class ShopDb
    {
        /// <summary>
        /// Gets or sets marketplace ID.
        /// </summary>
        public int ShopId { get; set; }

        /// <summary>
        /// Gets or sets marketplace name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the reference of a marketplace.
        /// </summary>
        public string Reference { get; set; }

        public ICollection<ProductDB> Products { get; set; }

        public ICollection<UserDb> Users { get; set; }

    }
}