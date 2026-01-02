using System;
using Strava.Authentication;

namespace Strava.Clients
{
    /// <summary>
    /// Base class for all the clients except the StravaClient.
    /// </summary>
    public class BaseClient
    {
        /// <summary>
        /// IAuthentication object used for authentication.
        /// </summary>
        protected IAuthentication Authentication;

        /// <summary>
        /// Initializes a new instance of the BaseClient class.
        /// </summary>
        /// <param name="auth">A valid object that implements the IAuthentication interface.</param>
        public BaseClient(IAuthentication auth)
        {
            if (auth == null)
            {
                throw new ArgumentException("The IAuthentication object must not be null!");
            }

            Authentication = auth;

            System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls11 | System.Net.SecurityProtocolType.Tls12;
        }
    }
}
