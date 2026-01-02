namespace Strava.Filters
{
    /// <summary>
    /// Use this enum to filter a Strava segment leaderboard. You can only filter the leaderboard by gender, if you have a Strava 
    /// premium account. If you do not have one, use the value "Both".
    /// </summary>
    public enum GenderFilter
    {
        /// <summary>
        /// Female
        /// </summary>
        Female,
        /// <summary>
        /// Male
        /// </summary>
        Male,
        /// <summary>
        /// Both male and female riders are shown in the leaderboard. Use this value if you do not have a Strava 
        /// premium account!
        /// </summary>
        Both
    }
}