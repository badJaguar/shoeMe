using System.Collections.Generic;
using ShoeMeDear.DataAccess.Common.Models.Products;
using ShoeMeDear.DataAccess.Common.Models.Sizes;
using ShoeMeDear.DataAccess.Common.Models.Users;

namespace ShoeMeDear.DataAccess.Common.Models
{
    using System;

    public class GenderDb
    {
        /// <summary>
        /// Gets or sets a name of gender.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets gender created date time.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets gender modifying date time.
        /// </summary>
        public DateTime Modified { get; set; }

        public UserDb User { get; set; }

        public string UserId { get; set; }

        public ProductDB Product { get; set; }

        public string ProductId { get; set; }

        public virtual ICollection<ShoeSizeDb> Sizes { get; set; }
    }
}