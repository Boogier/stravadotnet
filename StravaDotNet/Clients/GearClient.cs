using System;
using System.Threading.Tasks;
using Strava.Api;
using Strava.Authentication;
using Strava.Common;
using Strava.Http;

namespace Strava.Clients
{
    /// <summary>
    /// Used to receive information about gear.
    /// </summary>
    public class GearClient : BaseClient
    {
        /// <summary>
        /// Initializes a new instance of the GearClient class.
        /// </summary>
        /// <param name="auth"></param>
        public GearClient(IAuthentication auth) : base(auth) { }

        #region Async

        /// <summary>
        /// Retrieves gear with the specified id asynchronously from the Strava servers.
        /// </summary>
        /// <param name="gearId">The Strava id of the gear.</param>
        /// <returns>The gear object.</returns>
        public async Task<Gear.Bike> GetGearAsync(string gearId)
        {
            string getUrl = string.Format("{0}/{1}?access_token={2}", Endpoints.Gear, gearId, Authentication.AccessToken);
            string json = await WebRequest.SendGetAsync(new Uri(getUrl));

            return Unmarshaller<Gear.Bike>.Unmarshal(json);
        }

        #endregion

        #region Sync

        /// <summary>
        /// Retrieves gear with the specified id from the Strava servers.
        /// </summary>
        /// <param name="gearId">The Strava id of the gear.</param>
        /// <returns>The gear object.</returns>
        public Gear.Bike GetGear(string gearId)
        {
            string getUrl = string.Format("{0}/{1}?access_token={2}", Endpoints.Gear, gearId, Authentication.AccessToken);
            string json = WebRequest.SendGet(new Uri(getUrl));

            return Unmarshaller<Gear.Bike>.Unmarshal(json);
        }

        #endregion
    }
}
