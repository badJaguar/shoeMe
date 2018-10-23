using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeMeDear.DataAccess.Common.Models
{
    /// <summary>
    /// Model for Product entity is used in database
    /// </summary>
    public class ProductDB
    {
        /// <summary>
        /// Unique identifier of concrete Product in database.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Unique name of concrete Product in database.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Product picture path.
        /// </summary>
        public string PicturePath { get; set; } //Возможно придется сделать модельку для картинок

        /// <summary>
        /// Defines the Product description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Specifies the timestamp of creation of concrete Product in database.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Specifies the timestamp of modifying of any property of the Product in database.
        /// </summary>
        public DateTime? Modified { get; set; }
    }
}
