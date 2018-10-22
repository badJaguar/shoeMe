namespace ShoeMeDear.Logic.Common.Models.Addresses
{
    public interface IAddress
    {
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