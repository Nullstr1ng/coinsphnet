namespace CoinsLib.Models
{
    public class Model_CryptoAccounts_Details
    {
        public string id { get; set; }
        public string name { get; set; }
        public string currency { get; set; }
        public string balance { get; set; }
        public string pending_balance { get; set; }
        public string default_address { get; set; }
    }
}
