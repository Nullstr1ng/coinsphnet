using CoinsLib.Security;
using System;
using System.Net;

namespace CoinsLib.Web
{
    public class WebRequests
    {
        WebClient client = null;

        static WebRequests _i = new WebRequests();
        public static WebRequests I { get { return _i; } }
        public WebRequests()
        {
        }

        public string HttpRequest(string url, bool secured = true)
        {
            string response = null;

            using (client = new WebClient()
            {
                UseDefaultCredentials = true
            })
            {
                if (secured)
                {
                    string nonce = CoinsAuth.getNONCE().ToString();
                    string signature = CoinsAuth.signRequest(url, nonce);

                    client.Headers.Add("ACCESS_SIGNATURE", signature);
                    client.Headers.Add("ACCESS_KEY", CoinsAPI.I.API_KEY);
                    client.Headers.Add("ACCESS_NONCE", nonce);
                }

                client.Headers.Add("Content-Type", "application/json");
                client.Headers.Add("Accept", "application/json");

                response = client.DownloadString(url);

            }

            return response;
        }
    }
}
