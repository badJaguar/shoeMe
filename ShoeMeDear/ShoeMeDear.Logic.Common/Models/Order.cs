namespace ShoeMeDear.Logic.Common.Models
{
    using System;
    using System.Collections.Generic;
    using Addresses;
    using Products;

    public class Order : IEquatable<Order>
    {
        /// <summary>
        /// Gets or sets the local destination address.
        /// </summary>
        public virtual Address Address { get; set; }

        /// <summary>
        /// Gets or sets how many packages in the order.
        /// </summary>
        public int CountPackages { get; set; }

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
        public virtual Product[] ProductArr { get; set; }

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
        /// Gets or sets the user who ordererd.
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        /// Gets or sets order virtual address.
        /// </summary>
        public virtual VirtualAddress VirtualAddress { get; set; }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Order);
        }

        public bool Equals(Order other)
        {
            return other != null &&
                   EqualityComparer<Address>.Default.Equals(this.Address, other.Address) &&
                   this.CountPackages == other.CountPackages &&
                   this.DeliveryPrice == other.DeliveryPrice &&
                   this.Id == other.Id &&
                   EqualityComparer<Product[]>.Default.Equals(this.ProductArr, other.ProductArr) &&
                   this.PublicId == other.PublicId &&
                   this.Success == other.Success &&
                   this.SummaryPrice == other.SummaryPrice &&
                   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
                   EqualityComparer<VirtualAddress>.Default.Equals(this.VirtualAddress, other.VirtualAddress);
        }

        public override int GetHashCode()
        {
            var hashCode = 459388872;
            hashCode = (hashCode * -1521134295) + EqualityComparer<Address>.Default.GetHashCode(this.Address);
            hashCode = (hashCode * -1521134295) + this.CountPackages.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.DeliveryPrice.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(this.Id);
            hashCode = (hashCode * -1521134295) + EqualityComparer<Product[]>.Default.GetHashCode(this.ProductArr);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(this.PublicId);
            hashCode = (hashCode * -1521134295) + this.Success.GetHashCode();
            hashCode = (hashCode * -1521134295) + this.SummaryPrice.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<User>.Default.GetHashCode(this.User);
            hashCode = (hashCode * -1521134295) + EqualityComparer<VirtualAddress>.Default.GetHashCode(this.VirtualAddress);
            return hashCode;
        }
    }
}