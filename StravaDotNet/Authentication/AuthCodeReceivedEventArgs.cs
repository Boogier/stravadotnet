using System;

namespace Strava.Authentication
{
    /// <summary>
    /// This class contains information about an auth token received from Strava.
    /// </summary>
    public class AuthCodeReceivedEventArgs
    {
        /// <summary>
        /// the auth token received from Strava.
        /// </summary>
        public string AuthCode { get; set; }

        /// <summary>
        /// Initializes a new instance of the AuthCodeReceivedEventArgs class.
        /// </summary>
        /// <param name="code">The auth code received from Strava.</param>
        public AuthCodeReceivedEventArgs(string code)
        {
            AuthCode = code;
        }
    }
}
