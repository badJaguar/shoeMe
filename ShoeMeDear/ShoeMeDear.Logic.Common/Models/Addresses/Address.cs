namespace ShoeMeDear.Logic.Common.Models.Addresses

{
    /// <summary>
    /// Represents the real users address.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets user's city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets user's country of destination.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets user full name.
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// Gets or sets unique string GUID identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether postal code is exist or not.
        /// </summary>
        public bool IsExist { get; set; }

        /// <summary>
        /// Gets or sets a data of mobile phone number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets State/Province/Region/
        /// </summary>
        public string StPrRegion { get; set; }

        /// <summary>
        /// Gets or sets street address.
        /// </summary>
        public string StreetAddress { get; set; }

        /// <summary>
        /// Gets or sets zip postal code.
        /// </summary>
        public int ZipPostal { get; set; }
    }
}