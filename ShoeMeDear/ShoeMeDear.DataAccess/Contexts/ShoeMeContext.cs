namespace ShoeMeDear.DataAccess.Contexts
{
    using System.Data.Entity;
    using Common.Models;
    using Common.Models.Addresses;
    using Common.Models.Products;
    using Common.Models.Sizes;
    using Config;

    [DbConfigurationType(typeof(MsSqlConfiguration))]
    public class ShoeMeContext : DbContext
    {
        public IDbSet<BrandDb> Brands { get; set; }

        public IDbSet<OrderDb> Orders { get; set; }

        public IDbSet<GenderDb> Genders { get; set; }

        public IDbSet<ShoeSizeDb> ShoeSizes { get; set; }

        public IDbSet<ProductDB> Products { get; set; }

        public IDbSet<VirtualAddressDb> VirtualAddresses { get; set; }

        public IDbSet<AddressDb> Addresses { get; set; }
    }
}