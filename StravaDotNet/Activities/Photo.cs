using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Strava.Activities
{
    /// <summary>
    /// Represents a photo linked to an activity.
    /// </summary>
    public class Photo
    {
        [JsonProperty("urls")]
        public Dictionary<int, string> Urls { get; set; } = new();

        [JsonProperty("created_at")]
        private string? _createdAt { get; set; }

        public DateTime? CreatedAt => DateTime.TryParse(_createdAt, out var d) ? d : null;

        [JsonProperty("created_at_local")]
        private string? _createdAtLocal { get; set; }

        public DateTime? CreatedAtLocal => DateTime.TryParse(_createdAt, out var d) ? d : null;

        [JsonProperty("unique_id")]
        public Guid Id { get; set; }

        /// <summary>
        /// The id of the activity to which the photo is connected to.
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// The level of detail.
        /// </summary>
        [JsonProperty("resource_state")]
        public int ResourceState { get; set; }

        /// <summary>
        /// Url to the picture. Use the ImageLoader class to download the picture.
        /// </summary>
        [JsonProperty("ref")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The photo's external id.
        /// </summary>
        [JsonProperty("uid")]
        public string ExternalUid { get; set; }

        /// <summary>
        /// The caption.
        /// </summary>
        [JsonProperty("caption")]
        public string Caption { get; set; }

        /// <summary>
        /// Image source. Currently only "InstagramPhoto"
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The date when the image was uploaded.
        /// </summary>
        [JsonProperty("uploaded_at")]
        public string UploadedAt { get; set; }

        /// <summary>
        /// The location where the picture was taken.
        /// </summary>
        [JsonProperty("location")]
        public List<double> Location { get; set; }
    }
}
