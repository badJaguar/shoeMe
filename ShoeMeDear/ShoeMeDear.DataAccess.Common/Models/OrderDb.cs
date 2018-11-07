using System;

namespace ShoeMeDear.DataAccess.Common.Models
{
    using Addresses;
    using Products;
    using System.Collections.Generic;

    public class OrderDb : IEquatable<OrderDb>
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
        public virtual ProductDB[] ProductArr { get; set; }

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
            return this.Equals(obj as OrderDb);
        }

        public bool Equals(OrderDb other)
        {
            return other != null &&
                   EqualityComparer<AddressDb>.Default.Equals(this.Address, other.Address) &&
                   this.CountPackages == other.CountPackages &&
                   this.Created == other.Created &&
                   this.DeliveryPrice == other.DeliveryPrice &&
                   this.Id == other.Id &&
                   EqualityComparer<ProductDB[]>.Default.Equals(this.ProductArr, other.ProductArr) &&
                   this.PublicId == other.PublicId &&
                   this.Success == other.Success &&
                   this.SummaryPrice == other.SummaryPrice &&
                   EqualityComparer<DateTime?>.Default.Equals(this.Updated, other.Updated) &&
                   EqualityComparer<UserDb>.Default.Equals(this.User, other.User) &&
                   EqualityComparer<VirtualAddressDb>.Default.Equals(this.VirtualAddress, other.VirtualAddress);
        }

        public override int GetHashCode()
        {
            var hashCode = -1262987077;
            hashCode = (hashCode * -1521134295) + EqualityComparer<AddressDb>.Default.GetHashCode(this.Address);
            hashCode = (hashCode * -1521134295) + this.CountPackages.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.Created.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.DeliveryPrice.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(this.Id);
            hashCode = (hashCode * -1521134295) + EqualityComparer<ProductDB[]>.Default.GetHashCode(this.ProductArr);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(this.PublicId);
            hashCode = (hashCode * -1521134295) + this.Success.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.SummaryPrice.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<DateTime?>.Default.GetHashCode(this.Updated);
            hashCode = (hashCode * -1521134295) + EqualityComparer<UserDb>.Default.GetHashCode(this.User);
            hashCode = (hashCode * -1521134295) + EqualityComparer<VirtualAddressDb>.Default.GetHashCode(this.VirtualAddress);
            return hashCode;
        }
    }
}