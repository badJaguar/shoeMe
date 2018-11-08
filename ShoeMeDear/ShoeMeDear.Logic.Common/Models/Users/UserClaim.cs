namespace ShoeMeDear.Logic.Common.Models.Users
{
    /// <summary>
    /// EntityType that represents one specific user claim.
    /// </summary>
    public class UserClaim
    {
        /// <summary>
        /// Gets or sets claim type.
        /// </summary>
        public string ClaimType { get; set; }

        /// <summary>
        /// Gets or sets claim value.
        /// </summary>
        public string ClaimValue { get; set; }
    }
}
