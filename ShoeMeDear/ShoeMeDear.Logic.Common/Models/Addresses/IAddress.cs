namespace ShoeMeDear.Logic.Common.Models.Addresses
{
    /// <summary>
    /// Represents the real users address.
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// Gets or sets unique GUID identifier
        /// </summary>
        string Id { get; set; }

        string Fullname { get; set; }

        string Country { get; set; }

        string StreetAddress { get; set; }

        string City { get; set; }

        string StPrRegion { get; set; }

        int ZipPostal { get; set; }

        bool IsExist { get; set; }

        string Mobile { get; set; }
    }
}