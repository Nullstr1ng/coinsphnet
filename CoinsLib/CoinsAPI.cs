namespace CoinsLib
{
    public enum Enum_Markets
    {
        BCH_PHP,
        BTC_CLP,
        BTC_HKD,
        BTC_IDR,
        BTC_MYR,
        BTC_PHP,
        BTC_THB,
        BTC_TWD,
        BTC_USD,
        BTC_VND,
        ETH_PHP,
        LTC_PHP,
        USD_PHP,
        XRP_PHP
    }

    public class CoinsAPI
    {
        private static string _API_KEY = string.Empty;
        public string API_KEY
        {
            get { return _API_KEY; }
            set
            {
                if (_API_KEY != value)
                {
                    _API_KEY = value;
                }
            }
        }

        private static string _API_SECRET = string.Empty;
        public string API_SECRET
        {
            get { return _API_SECRET; }
            set
            {
                if (_API_SECRET != value)
                {
                    _API_SECRET = value;
                }
            }
        }


        private static Enum_Markets _MarketsRate = Enum_Markets.BTC_PHP;
        public Enum_Markets MarketsRate
        {
            get { return _MarketsRate; }
            set
            {
                if (_MarketsRate != value)
                {
                    _MarketsRate = value;
                }
            }
        }

        static CoinsAPI _i = new CoinsAPI();
        public static CoinsAPI I { get { return _i; } }
        public CoinsAPI()
        {

        }
    }
}
