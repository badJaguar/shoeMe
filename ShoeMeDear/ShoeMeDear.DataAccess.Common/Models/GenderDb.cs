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
        public DateTime? Modified { get; set; }
    }
}