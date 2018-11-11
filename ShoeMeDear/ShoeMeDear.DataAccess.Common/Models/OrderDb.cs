namespace ShoeMeDear.DataAccess.Common.Models
{
    using System;
    using System.Collections.Generic;
    using Addresses;
    using Products;
    using Users;

    public class OrderDb
    {
        /// <summary>
        /// Gets or sets the local destination address.
        /// </summary>
        public virtual AddressDb Address { get; set; }

        /// <summary>
        /// Gets or sets how many packages in the order.
        /// </summary>
        public int CountPackages { get; set; }

        /// <summary>
        /// Gets or sets order created date time.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets delivery price.
        /// </summary>
        public double DeliveryPrice { get; set; }

        /// <summary>
        /// Gets or sets private ID for DB saving.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets product(s) in the order.
        /// </summary>
        public virtual ICollection<ProductDB> Products { get; set; }

        /// <summary>
        /// Gets or sets Order ID for user and delivery.
        /// </summary>
        public string PublicId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether order successed or not.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Gets or sets the summary price of order.
        /// </summary>
        public double SummaryPrice { get; set; }

        /// <summary>
        /// Gets or sets order updating date time.
        /// </summary>
        public DateTime? Updated { get; set; }

        /// <summary>
        /// Gets or sets the user who ordererd.
        /// </summary>
        public virtual UserDb User { get; set; }

        /// <summary>
        /// Gets or sets order virtual address.
        /// </summary>
        public virtual VirtualAddressDb VirtualAddress { get; set; }

        public override bool Equals(object obj)
        {
            var db = obj as OrderDb;
            return db != null &&
                   EqualityComparer<AddressDb>.Default.Equals(Address, db.Address) &&
                   CountPackages == db.CountPackages &&
                   Created == db.Created &&
                   DeliveryPrice == db.DeliveryPrice &&
                   Id == db.Id &&
                   EqualityComparer<ICollection<ProductDB>>.Default.Equals(Products, db.Products) &&
                   PublicId == db.PublicId &&
                   Success == db.Success &&
                   SummaryPrice == db.SummaryPrice &&
                   EqualityComparer<DateTime?>.Default.Equals(Updated, db.Updated) &&
                   EqualityComparer<UserDb>.Default.Equals(User, db.User) &&
                   EqualityComparer<VirtualAddressDb>.Default.Equals(VirtualAddress, db.VirtualAddress);
        }

        public override int GetHashCode()
        {
            var hashCode = -22285903;
            hashCode = hashCode * -1521134295 + EqualityComparer<AddressDb>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + CountPackages.GetHashCode();
            hashCode = hashCode * -1521134295 + Created.GetHashCode();
            hashCode = hashCode * -1521134295 + DeliveryPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<ICollection<ProductDB>>.Default.GetHashCode(Products);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PublicId);
            hashCode = hashCode * -1521134295 + Success.GetHashCode();
            hashCode = hashCode * -1521134295 + SummaryPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(Updated);
            hashCode = hashCode * -1521134295 + EqualityComparer<UserDb>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<VirtualAddressDb>.Default.GetHashCode(VirtualAddress);
            return hashCode;
        }
    }
}