namespace ShoeMeDear.Logic.Common.Models.Users
{
    public class User
    {
        /// <summary>
        /// Gets or sets a unique GUID identifier.
        /// </summary>
        public virtual string Id { get; set; }

        /// <summary>
        /// Gets or sets user first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets user last name.
        /// </summary>
        public string LastName { get; set; }

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