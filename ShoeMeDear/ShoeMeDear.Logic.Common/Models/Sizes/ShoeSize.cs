namespace ShoeMeDear.Logic.Common.Models.Sizes
{
    using System.Collections.Generic;

    public class ShoeSize
    {
        /// <summary>
        /// Gets or sets gender and age category.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets unique identifier of a size.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the value of a size.
        /// </summary>
        public double Value { get; set; }

        public override bool Equals(object obj)
        {
            return obj is ShoeSize size &&
                   this.Gender == size.Gender &&
                   this.Id == size.Id &&
                   this.Value == size.Value;
        }

        public override int GetHashCode()
        {
            var hashCode = 1419063306;
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Gender);
            hashCode = (hashCode * -1521134295) + this.Id.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.Value.GetHashCode();
            return hashCode;
        }
    }
}