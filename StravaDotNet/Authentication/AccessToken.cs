using System;
using Newtonsoft.Json;

namespace Strava.Authentication
{
    /// <summary>
    /// This class holds an access token.
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// The access token.
        /// </summary>
        [JsonProperty("access_token")]
        public string Token { get; set; }
    }
}
