using System;

namespace Strava.Authentication
{
    /// <summary>
    /// Thius class holds information about a access token that was received from the server.
    /// </summary>
    public class TokenReceivedEventArgs
    {
        /// <summary>
        /// The received access token.
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Initializes a new instance of the TokenReceivedEventArgs class.
        /// </summary>
        /// <param name="token">The token received from the server.</param>
        public TokenReceivedEventArgs(string token)
        {
            Token = token;
        }
    }
}
