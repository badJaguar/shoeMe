namespace ShoeMeDear.DataAccess.Common.Models.Users
{
    /// <summary>
    /// Entity type for a user's login by third party sevice (i.e. facebook, google).
    /// </summary>
    public class UserLoginDb
    {
        /// <summary>
        /// Gets or sets the login provider for the login (i.e. facebook, google).
        /// </summary>
        public string LoginProvider { get; set; }

        /// <summary>
        /// Gets or sets key representing the login for the provider.
        /// </summary>
        public string ProviderKey { get; set; }
    }
}