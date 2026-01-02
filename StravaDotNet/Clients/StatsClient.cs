using System;
using System.Threading.Tasks;
using Strava.Athletes;
using Strava.Authentication;
using Strava.Common;
using Strava.Statistics;

namespace Strava.Clients
{
    /// <summary>
    /// Used to get statistics data from Strava.
    /// </summary>
    public class StatsClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the StatsClient class.
        /// </summary>
        /// <param name="auth">A IAuthenticator object that contains a valid Strava access token.</param>
        public StatsClient(IAuthentication auth) : base(auth) { }

        #region async

        /// <summary>
        /// Gets some stats of the currently authenticated user.
        /// </summary>
        /// <param name="id">The id of the user. <remarks>Must match the authenticated athlete!</remarks></param>
        /// <returns>Strava statistics of the currently authenticated user.</returns>
        private async Task<Stats> GetStatsAsync(string id)
        {
            string getUrl = string.Format("https://www.strava.com/api/v3/athletes/{0}/stats?access_token={1}", id, Authentication.AccessToken);
            string json = await Http.WebRequest.SendGetAsync(new Uri(getUrl));

            return Unmarshaller<Stats>.Unmarshal(json);
        }

        /// <summary>
        /// Gets some stats of the currently authenticated user.
        /// </summary>
        /// <returns>Strava statistics of the currently authenticated user.</returns>
        public async Task<Stats> GetStatsAsync()
        {
            // Get the athlete
            AthleteClient client = new AthleteClient(base.Authentication);
            Athlete a = await client.GetAthleteAsync();

            return await GetStatsAsync(a.Id.ToString());
        }

        #endregion

        #region sync
        #endregion
    }
}
