namespace Strava.Filters
{
    /// <summary>
    /// This enum is used to filter a segment leaderboard. A Strava premium account is needed to filter a segment leasderboard.
    /// </summary>
    public enum AgeFilter
    {
        /// <summary>
        /// 0-24
        /// </summary>
        One,
        /// <summary>
        /// 25-34
        /// </summary>
        Two,
        /// <summary>
        /// 35-44
        /// </summary>
        Three,
        /// <summary>
        /// 45-54
        /// </summary>
        Four,
        /// <summary>
        /// 55-64
        /// </summary>
        Five,
        /// <summary>
        /// 65+
        /// </summary>
        Six,
        /// <summary>
        /// The Strava Leaderboard doesn't get filtered by age.
        /// </summary>
        All
    }
}