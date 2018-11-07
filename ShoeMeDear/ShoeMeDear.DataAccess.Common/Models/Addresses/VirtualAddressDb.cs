using System;

namespace ShoeMeDear.DataAccess.Common.Models.Addresses
{
    public class VirtualAddressDb
    {

        /// <summary>
        /// Gets or sets user's city.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Gets or sets user country.
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets address created date.
        /// </summary>
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets user full name.
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Gets or sets unique string GUID identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets Line1 address.
        /// </summary>
        public string Line1 { get; set; }

        /// <summary>
        /// Gets or sets Line2 address.
        /// </summary>
        public string Line2 { get; set; }

        /// <summary>
        /// Gets or sets a data of mobile phone number.
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// Gets or sets address modifying date time.
        /// </summary>
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Gets or sets a state in the USA.
        /// </summary>
        public string State { get; set; } // На некоторых площадках штат вводится по-разнаму. Например ("NY" или "New York")

        /// <summary>
        /// Gets or sets zip postal code.
        /// </summary>
        public string ZipPostal { get; set; } // В штатах зипкод пишется через дефис. Поэтому 'string'.
    }
}