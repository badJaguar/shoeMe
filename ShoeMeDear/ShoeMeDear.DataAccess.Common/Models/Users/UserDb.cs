using System.Collections.Generic;
using ShoeMeDear.DataAccess.Common.Models.Addresses;
using ShoeMeDear.DataAccess.Common.Models.Sizes;

namespace ShoeMeDear.DataAccess.Common.Models.Users
{
    public class UserDb : UserIdentityDb
    {
        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a unique GUID identifier.
        /// </summary>
        public override string Id { get; set; }

        /// <summary>
        /// Gets or sets user first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets user last name.
        /// </summary>
        public string LastName { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets user email.
        /// </summary>
        public override string Email { get; set; }

        /// <inheritdoc />
        /// <summary>
        /// Gets or sets a value indicating whether is email confirmed or not.
        /// </summary>
        public override bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets user phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether phone number confirmed or not.
        /// </summary>
        public bool PhoneConfirmed { get; set; }

        public virtual ICollection<AddressDb> Addresses { get; set; }

        public virtual VirtualAddressDb VirtualAddress { get; set; }

        public string VirtualAddressId { get; set; }

        public virtual ICollection<OrderDb> Orders { get; set; }

        public virtual ICollection<ShoeSizeDb> Sizes { get; set; }
    }
}