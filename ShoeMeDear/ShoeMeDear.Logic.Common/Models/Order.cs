namespace ShoeMeDear.Logic.Common.Models
{
    using Addresses;
    using Products;

    public class Order
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
    }
}