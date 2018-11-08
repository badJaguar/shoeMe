namespace ShoeMeDear.DataAccess.Common.Models.Users
{
    public class UserDb
    {
        /// <summary>
        /// Gets or sets a unique GUID identifier.
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        public virtual string UserName { get; set; }

        /// <summary>
        /// Gets or sets user email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether is email confirmed or not.
        /// </summary>
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets user phone number.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether phone number confirmed or not.
        /// </summary>
        public bool PhoneConfirmed { get; set; }
    }
}