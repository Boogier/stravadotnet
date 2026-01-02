using Newtonsoft.Json;

namespace Strava.Statistics
{
    /// <summary>
    /// This class contains all statistics of an athlete.
    /// </summary>
    public class Stats
    {
        /// <summary>
        /// The distance of your biggest ride.
        /// </summary>
        [JsonProperty("biggest_ride_distance")]
        public double BiggestRideDistance { get; set; }

        /// <summary>
        /// The most elevation gain in a single ride.
        /// </summary>
        [JsonProperty("biggest_climb_elevation_gain")]
        public double BiggestClimbElevationGain { get; set; }

        /// <summary>
        /// Statistics about your recent rides.
        /// </summary>
        [JsonProperty("recent_ride_totals")]
        public RecentRideTotals RecentRideTotals { get; set; }

        /// <summary>
        /// Statistics about your recent runs.
        /// </summary>
        [JsonProperty("recent_run_totals")]
        public RecentRunTotals RecentRunTotals { get; set; }

        /// <summary>
        /// Ride statistics from this year.
        /// </summary>
        [JsonProperty("ytd_ride_totals")]
        public YearToDateRideTotals YearToDateRideTotals { get; set; }

        /// <summary>
        /// Run statistics from this year.
        /// </summary>
        [JsonProperty("ytd_run_totals")]
        public YearToDateRunTotals YearToDateRunTotals { get; set; }

        /// <summary>
        /// Total ride statistics.
        /// </summary>
        [JsonProperty("all_ride_totals")]
        public AllRideTotals RideTotals { get; set; }

        /// <summary>
        /// Total run statistics.
        /// </summary>
        [JsonProperty("all_run_totals")]
        public AllRunTotals RunTotals { get; set; }
    }
}
