using CoinsLib.Models;
using CoinsLib.Web;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CoinsLib.API
{
    public class Markets
    {
        public Markets()
        {

        }

        public Model_MarketRates_Details getMarketRate(Enum_Markets market = Enum_Markets.BTC_PHP)
        {
            string url = string.Empty;
            url = "https://quote.coins.ph/v1/markets" + $"/{market.ToString().Replace("_", "-")}";

            string response = WebRequests.I.HttpRequest(url, false);
            //Debug.WriteLine(response);

            Model_MarketRates market_rate = null;

            market_rate = JsonConvert.DeserializeObject<Model_MarketRates>(response);

            return market_rate.market;
        }

        public List<Model_MarketRates_Details> getMarketRates()
        {
            string url = string.Empty;
            url = "https://quote.coins.ph/v1/markets";

            string response = WebRequests.I.HttpRequest(url, false);
            //Debug.WriteLine(response);

            Model_MarketRates market_rate = null;

            market_rate = JsonConvert.DeserializeObject<Model_MarketRates>(response);

            return market_rate.markets;
        }
    }
}
