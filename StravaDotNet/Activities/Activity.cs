using System.Collections.Generic;
using Strava.Gear;
using Strava.Segments;
using Newtonsoft.Json;

namespace Strava.Activities
{
    /// <summary>
    /// Activities are the base object for Strava runs, rides, swims etc.
    /// </summary>
    public class Activity : ActivitySummary
    {
        /// <summary>
        /// A list of segment effort objects.
        /// </summary>
        [JsonProperty("segment_efforts")]
        public List<SegmentEffort> SegmentEfforts { get; set; }

        /// <summary>
        /// A summary of the gear used.
        /// </summary>
        [JsonProperty("gear")]
        public GearSummary Gear { get; set; }

        /// <summary>
        /// the burned kilocalories.
        /// </summary>
        [JsonProperty("calories")]
        public float Calories { get; set; }

        /// <summary>
        /// The activity's description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// A list of best efforts for activity.
        /// </summary>
        [JsonProperty("best_efforts")]
        public List<BestEffort> BestEfforts { get; set; }

        /// <summary>
        /// he name of the device used to record the activity.
        /// </summary>
        [JsonProperty("device_name")]
        public string DeviceName { get; set; }

   
        /* ToAdd :
        splits_metric
        splits_standard
        device_name
        photos


    */
    }
}
