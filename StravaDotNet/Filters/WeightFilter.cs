namespace Strava.Filters
{
    /// <summary>
    /// This enum is used to filter a segment leaderboard. You need a Strava premium account to filter segment leaderboards.
    /// </summary>
    public enum WeightFilter
    {
        /// <summary>
        /// 0-124 pounds - 0-54 kg 
        /// </summary>
        One,
        /// <summary>
        /// 125-149 pounds - 55-64 kg
        /// </summary>
        Two,
        /// <summary>
        /// 150-164 pounds - 65-74 kg
        /// </summary>
        Three,
        /// <summary>
        /// 165-179 pounds - 75-84kg
        /// </summary>
        Four,
        /// <summary>
        /// 180-199 pounds - 85-94kg
        /// </summary>
        Five,
        /// <summary>
        /// 200+ pounds - 95+ kg
        /// </summary>
        Six,
        /// <summary>
        /// All riders are shown and the leaderboard doesn't get filtered by weight. Use this value if you 
        /// do not have a Strava premium account!
        /// </summary>
        All
    }
}