using System.Diagnostics;
using System.Threading.Tasks;

namespace Strava.Authentication;

/// <summary>
/// This class is used to start a local web server to receive a callback message from Strava. This message 
/// contains a auth token. This token is then used to obtain an access token.
/// Using this class requires admin privileges.
/// </summary>
public class WebAuthentication : IAuthentication
{
    public WebAuthentication(string accessToken)
    {
        AccessToken = accessToken;
    }

    /// <summary>
    /// The access token that was received from the Strava server.
    /// </summary>
    public string AccessToken { get; private set; }

    /// <summary>
    /// Loads an access token asynchronously from the Strava servers. Invoking this method opens a web browser.
    /// </summary>
    /// <param name="clientId">The client id from your application (provided by Strava).</param>
    /// <param name="clientSecret">The client secret (provided by Strava).</param>
    /// <param name="scopeLevel">Define what your application is allowed to do.</param>
    /// <param name="callbackPort">Define the callback port (optional, default value is 1895). Only change this, 
    /// if the default port 1895 is already used on your machine.</param>
    public Task GetTokenAsync(string clientId, string clientSecret, string scopeLevel, int callbackPort = 18795)
    {
        var server = new LocalWebServer($"http://localhost:{callbackPort}/")
        {
            ClientId = clientId,
            ClientSecret = clientSecret
        };

        var tcs = new TaskCompletionSource();

        server.AccessTokenReceived += delegate(object sender, TokenReceivedEventArgs args)
        {
            if (args.Token != null)
            {
                AccessToken = args.Token;
                tcs.TrySetResult();
                server.Stop();
            }
        };

        server.Start();

        var authorizationUrl =
            $"https://www.strava.com/oauth/authorize?client_id={clientId}&redirect_uri=http://localhost:{callbackPort}&response_type=code&scope=activity:read_all";

        Process.Start(new ProcessStartInfo
        {
            FileName = authorizationUrl,
            UseShellExecute = true
        });

        return tcs.Task;
    }
}