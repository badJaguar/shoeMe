namespace ShoeMeDear.DataAccess.Common.Models.Sizes
{
    using System;

    public class ShoeSizeDb
    {
        /// <summary>
        /// Gets or sets gender and age category.
        /// </summary>
        public int GenderId { get; set; }

        public virtual GenderDb Gender { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of a size.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the value of a size.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets shoes size modifying date time.
        /// </summary>
        public DateTime Modified { get; set; }

        /// <summary>
        /// Gets or sets shoes size modifying date time.
        /// </summary>
        public DateTime Created { get; set; }
    }
}