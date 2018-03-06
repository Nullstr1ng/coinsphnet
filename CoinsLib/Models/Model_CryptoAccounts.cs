using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinsLib.Models
{
    public class Model_CryptoAccounts
    {
        [JsonProperty("meta")]
        public object meta { get; set; }

        [JsonProperty("crypto-accounts")]
        public List<Model_CryptoAccounts_Details> crypto_accounts { get; set; }
    }
}
