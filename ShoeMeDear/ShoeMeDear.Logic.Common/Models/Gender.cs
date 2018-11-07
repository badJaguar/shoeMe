namespace ShoeMeDear.Logic.Common.Models
{
    public class Gender
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
        /// Gets or sets a flag is size was chosen or not.
        /// </summary>
        public bool Added { get; set; }
    }
}