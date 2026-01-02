using System;

namespace Strava.Authentication
{
    /// <summary>
    /// This class is used to authenticate with Strava.
    /// </summary>
    public class StaticAuthentication : IAuthentication
    {
        /// <summary>
        /// The access token used to authenticate with Strava.
        /// </summary>
        public string AccessToken { get; set; }

        /// <summary>
        /// Initializes a new instance of the StaticAuthentication class.
        /// </summary>
        /// <param name="accessToken">The access token.</param>
        public StaticAuthentication(string accessToken)
        {
            AccessToken = accessToken;
        }
    }
}
