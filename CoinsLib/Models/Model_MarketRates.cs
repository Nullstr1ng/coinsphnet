using Newtonsoft.Json;
using System.Collections.Generic;

namespace CoinsLib.Models
{
    public class Model_MarketRates
    {
        [JsonProperty("markets")]
        public List<Model_MarketRates_Details> markets { get; set; }

        [JsonProperty("market")]
        public Model_MarketRates_Details market { get; set; }
    }
}
