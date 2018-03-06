using CoinsLib.Models;
using CoinsLib.Web;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;

namespace CoinsLib.API
{
    public class Wallets
    {
        public enum Enum_Currency
        {
            NONE, BTC, PBTC
        }

        public Model_CryptoAccounts getCryptoAccounts(Enum_Currency currency = Enum_Currency.NONE)
        {
            string url = string.Empty;
            url = "https://coins.ph/api/v3/crypto-accounts/" + (currency != Enum_Currency.NONE ? $"?currency={currency.ToString()}" : "");

            string response = WebRequests.I.HttpRequest(url);
            //Debug.WriteLine(response);

            Model_CryptoAccounts acc = JsonConvert.DeserializeObject<Model_CryptoAccounts>(response);

            if (currency != Enum_Currency.NONE)
            {
                var a = from b in acc.crypto_accounts
                        where b.currency.ToString().ToUpper() == currency.ToString()
                        select b;
                if(a.Count() > 0)
                {
                    acc.crypto_accounts = a.ToList();
                }
            }

            return acc;
        }

        public string getCryptoExchanges(int id = 0)
        {
            string url = string.Empty;
            url = "https://coins.ph/api/v3/crypto-exchanges/" + (id != 0 ? $":{id}/" : "");

            string response = WebRequests.I.HttpRequest(url);
            //Debug.WriteLine(response);

            //Model_CryptoAccounts acc = JsonConvert.DeserializeObject<Model_CryptoAccounts>(response);

            return response;
        }
    }
}