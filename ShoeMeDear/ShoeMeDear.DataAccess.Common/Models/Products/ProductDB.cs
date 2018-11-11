using System;
using System.Collections.Generic;

namespace ShoeMeDear.DataAccess.Common.Models.Products
{
    /// <summary>
    /// Model for Product entity is used in database
    /// </summary>
    public class ProductDB
    {
        /// <summary>
        /// Gets or sets unique identifier of concrete Product in database.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets unique name of concrete Product in database.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets product picture path.
        /// </summary>
        public string PicturePath { get; set; } // Возможно придется сделать модельку для картинок

        /// <summary>
        /// Gets or sets defines the Product description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets specifies the timestamp of creation of concrete Product in database.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets specifies the timestamp of modifying of any property of the Product in database.C:\Users\aleks\Desktop\ShoeMeDear\ShoeMeDear\ShoeMeDear.DataAccess.Common\Models\Products\ProductDB.cs
        /// </summary>
        public DateTime? Modified { get; set; }

        public virtual BrandDb Brand { get; set; }

        // public virtual ICollection<OrderDb> Orders { get; set; } // TODO: Додумать
    }
}
