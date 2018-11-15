﻿namespace ShoeMeDear.DataAccess.Common.Models.Products
{
    using System;
    using System.Collections.Generic;

    public class BrandDb
    {
        /// <summary>
        /// Gets or sets unique identifier of product brand.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a brand name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a date and time when brand was added.
        /// </summary>
        public DateTime Added { get; set; }

        /// <summary>
        /// Gets or sets a date and time when brand was removed.
        /// </summary>
        public DateTime Removed { get; set; }

        public virtual ICollection<ProductDB> Products { get; set; }
    }
}