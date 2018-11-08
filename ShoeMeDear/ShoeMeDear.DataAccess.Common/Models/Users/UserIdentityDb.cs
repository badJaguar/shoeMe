namespace ShoeMeDear.DataAccess.Common.Models.Users
{
    using Microsoft.AspNet.Identity.EntityFramework;

    public class UserIdentityDb : IdentityUser
    {
        public virtual UserDb UserDb { get; set; }
    }
}