using System;
using System.Collections.Generic;
using ShoeMeDear.DataAccess.Common.Models.Users;

namespace ShoeMeDear.DataAccess.Common.Models.Addresses
{
    public class AddressDb
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
        /// Gets or sets address created date.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets user full name.
        /// </summary>
        public string Fullname { get; set; }

        /// <summary>
        /// Gets or sets unique string GUID identifier.
        /// </summary>
        public string AddressId { get; set; }

        /// <summary>
        /// Gets or sets a data of mobile phone number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets address modifying date time.
        /// </summary>
        public DateTime Modified { get; set; }

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

        public virtual ICollection<UserDb> Users { get; set; }

        public virtual ICollection<OrderDb> Orders { get; set; }
    }
}