using System;
using System.Security.Cryptography;
using System.Text;

namespace CoinsLib.Security
{
    public class CoinsAuth
    {
        public static long getNONCE()
        {
            double totalSec = DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            long unixTimestamp = (long)Math.Round(totalSec * 1e6, 0);

            return unixTimestamp;
        }

        public static string signRequest(string url, string nonce, string body = null)
        {
            string message = string.Empty;

            if (body == null)
            {
                message = nonce + url;
            }
            else
            {

            }

            Console.WriteLine(message);

            string result = string.Empty;

            byte[] hmac = HashHMAC(Encoding.ASCII.GetBytes(CoinsAPI.I.API_SECRET),
                                   Encoding.ASCII.GetBytes(message));

            result = BitConverter.ToString(hmac).Replace("-", null);
            result = result.ToLower();

            Console.WriteLine(result);

            return result;
        }

        private static byte[] HashHMAC(byte[] key, byte[] message)
        {
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(message);
        }
    }
}
