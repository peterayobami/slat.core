namespace Slat.Core
{
    /// <summary>
    /// The routes for all web endpoints
    /// </summary>
    public class WebRoutes
    {
        /// <summary>
        /// The route to the login page endpoint
        /// </summary>
        public const string Login = "/user/login";

        /// <summary>
        /// The route to the logout page endpoint
        /// </summary>
        public const string Logout = "/user/logout";

        /// <summary>
        /// The route to redirect to login
        /// </summary>
        public const string LoginRoute = "/identity/login/route";

        /// <summary>
        /// The route to sign a user
        /// </summary>
        public const string SignIn = "/identity/login";

        /// <summary>
        /// The route to the identity error page endpoint
        /// </summary>
        public const string IdentityError = "/identity/logout";
    }
}
