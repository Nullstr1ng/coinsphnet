namespace CoinsLib.Models
{
    public class Model_MarketRates_Details
    {
        public string symbol { get; set; }
        public string currency { get; set; }
        public string product { get; set; }
        public string bid { get; set; }
        public string ask { get; set; }
        public string expires_in_seconds { get; set; }
    }
}
