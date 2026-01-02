using System;
using Newtonsoft.Json;

namespace Strava.Upload
{
    /// <summary>
    /// Contains information about the status of your upload.
    /// </summary>
    public class UploadStatus
    {
        /// <summary>
        /// The upload id of the activity. Provided by Strava upon upload.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The external id. Can not be changed.
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// Error message.
        /// </summary>
        [JsonProperty("error")]
        public string Error { get; set; }

        /// <summary>
        /// Status message.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// The Strava activity id.
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// Returns the status string as a more user-friendly enum.
        /// </summary>
        public CurrentUploadStatus CurrentStatus
        {
            get
            {
                switch (Status)
                {
                    case "Your activity is still being processed.":
                        return CurrentUploadStatus.Processing;
                    case "The created activity has been deleted.":
                        return CurrentUploadStatus.Deleted;
                    case "There was an error processing your activity.":
                        return CurrentUploadStatus.Error;
                }

                return CurrentUploadStatus.Ready;
            }
        }
    }
}