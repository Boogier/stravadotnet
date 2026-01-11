using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Strava.Common;

namespace Strava.Authentication
{
    /// <summary>
    /// This class starts a local web server. This web server is needed to receive the callback from
    /// Strava.
    /// </summary>
    public class LocalWebServer
    {
        /// <summary>
        /// AuthCodeReceived is raised whenever an auth code is received from the Strava servers.
        /// </summary>
        public event EventHandler<AuthCodeReceivedEventArgs> AuthCodeReceived;

        /// <summary>
        /// AccessTokenReceived is raised whenever an access token is received from the Strava servers.
        /// </summary>
        public event EventHandler<TokenReceivedEventArgs> AccessTokenReceived;

        /// <summary>
        /// The Client Id provided by Strava upon registering your application.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        /// The Client secret provided by Strava upon registering your application.
        /// </summary>
        public string ClientSecret { get; set; }

        private HttpListener _httpListener = new();
        private HttpListenerContext _context;

        /// <summary>
        /// Initializes a new instance of the LocalWebServer class.
        /// </summary>
        /// <param name="prefix">The server prefix.</param>
        public LocalWebServer(string prefix)
        {
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add(prefix);
        }

        /// <summary>
        /// Starts the local web server.
        /// </summary>
        public void Start()
        {
            _httpListener.Start();

            _ = ProcessRequestAsync();
        }

        /// <summary>
        /// Stops the local web server.
        /// </summary>
        public void Stop()
        {
            _httpListener.Stop();
        }

        /// <summary>
        /// Processes a request.
        /// </summary>
        public async Task ProcessRequestAsync()
        {
            _context = await _httpListener.GetContextAsync().ConfigureAwait(false);
            var queries = _context.Request.QueryString;

            // Access Token laden
            // 0 = state
            // 1 = code
            var code = queries.GetValues(1)[0];

            if (!string.IsNullOrEmpty(code))
            {
                if (AuthCodeReceived != null)
                {
                    AuthCodeReceived(this, new AuthCodeReceivedEventArgs(code));
                }
            }

            // Save token to hard disk
            var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "StravaApi");
            var file = Path.Combine(path, "AccessToken.auth");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            var stream = new FileStream(file, FileMode.OpenOrCreate);
            stream.Write(Encoding.UTF8.GetBytes(code), 0, Encoding.UTF8.GetBytes(code).Length);
            stream.Close();

            var b = Encoding.UTF8.GetBytes("Access token was loaded - You can close your browser window.");
            _context.Response.ContentLength64 = b.Length;
            await _context.Response.OutputStream.WriteAsync(b, 0, b.Length).ConfigureAwait(false);
            _context.Response.OutputStream.Close();


            // Getting the Access Token
            var url = $"https://www.strava.com/oauth/token?client_id={ClientId}&client_secret={ClientSecret}&code={code}";
            var json = await Http.WebRequest.SendPostAsync(new Uri(url));

            var auth = Unmarshaller<AccessToken>.Unmarshal(json);

            if (!string.IsNullOrEmpty(auth.Token))
            {
                if (AccessTokenReceived != null)
                {
                    AccessTokenReceived(this, new TokenReceivedEventArgs(auth.Token));
                }
            }
        }
    }
}