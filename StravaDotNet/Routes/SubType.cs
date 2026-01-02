namespace Strava.Routes
{
    /// <summary>
    /// The type of a route.
    /// </summary>
    public enum SubType
    {
        /// <summary>
        /// The route is a road bike route.
        /// </summary>
        Road = 1,
        /// <summary>
        /// The route is a MTB route.
        /// </summary>
        MTB = 2,
        /// <summary>
        /// The route is a CX route.
        /// </summary>
        CX = 3,
        /// <summary>
        /// The route is a trail route.
        /// </summary>
        Trail = 4,
        /// <summary>
        /// The route is a mixed route.
        /// </summary>
        Mixed = 5
    }
}
