using Strava.Athletes;
using Newtonsoft.Json;

namespace Strava.Clubs
{
    /// <summary>
    /// This class represents a club event.
    /// </summary>
    public class ClubEvent
    {
        /// <summary>
        /// The Strava Id of the club event.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Level of detail of the returned data.
        /// </summary>
        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        /// <summary>
        /// The title of the club event.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The Strava Id of the club.
        /// </summary>
        [JsonProperty("club_id")]
        public int ClubId { get; set; }

        /// <summary>
        /// The organising athlete of the club event.
        /// </summary>
        [JsonProperty("organizing_athlete")]
        public AthleteSummary Organizer { get; set; }

        /// <summary>
        /// The type of the club event.
        /// </summary>
        [JsonProperty("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// The data when the club event was crated by the organizer.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// If the club event takes place on a route that was crated using the Strava Route Builder, 
        /// this property holds the id of that route.
        /// </summary>
        [JsonProperty("route_id")]
        public int? RouteId { get; set; }

        /// <summary>
        /// True, if only women are allowed on this event.
        /// </summary>
        [JsonProperty("woman_only")]
        public bool IsWomanOnly { get; set; }

        /// <summary>
        /// True if the club event is private.
        /// </summary>
        [JsonProperty("private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// The skill level required to participate in this club event.
        /// </summary>
        [JsonProperty("skill_levels")]
        public int SkillLevels { get; set; }

        /// <summary>
        /// The terrain of the route.
        /// </summary>
        [JsonProperty("terrain")]
        public int Terrain { get; set; }

        /// <summary>
        /// Special occurences of the club event.
        /// </summary>
        [JsonProperty("upcoming_occurences")]
        public string[] Occurences { get; set; }

        /// <summary>
        /// The meeting point of the club event, i.e. where the evewnt starts.
        /// </summary>
        [JsonProperty("address")]
        public string Address{ get; set; }
    }
}
