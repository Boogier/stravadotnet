namespace Strava.Authentication;

/// <summary>
/// The IAuthentication is used for classes that contain methods to receive an access token from Strava.
/// </summary>
public interface IAuthentication
{
    /// <summary>
    /// The access token received from Strava.
    /// </summary>
    string AccessToken { get; }
}