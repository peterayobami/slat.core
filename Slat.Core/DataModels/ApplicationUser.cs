using Microsoft.AspNetCore.Identity;

namespace Slat.Core
{
    /// <summary>
    /// The application user model
    /// </summary>
    public class ApplicationUser : IdentityUser
    {
        /// <summary>
        /// The first name of the user
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        public string LastName { get; set; }
    }
}
