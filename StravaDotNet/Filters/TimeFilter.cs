namespace Strava.Filters
{
    /// <summary>
    /// Used to filter a segment leaderboard. Valid values from Strava are:
    /// this_year
    /// this_month
    /// this_week
    /// today
    /// </summary>
    public enum TimeFilter
    {
        /// <summary>
        /// Show efforts from this year.
        /// </summary>
        ThisYear,
        /// <summary>
        /// Show efforts from this month.
        /// </summary>
        ThisMonth,
        /// <summary>
        /// Show efforts from this week.
        /// </summary>
        ThisWeek,
        /// <summary>
        /// Show efforts from today.
        /// </summary>
        Today,
        /// <summary>
        /// The leaderboard does not get filtered by date.
        /// </summary>
        All
    }
}