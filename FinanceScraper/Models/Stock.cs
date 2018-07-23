namespace FinanceScraper.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        public string LastPrice { get; set; }

        public string Change { get; set; }

        public string PercentChange { get; set; }

        public string Currency { get; set; }

        public string MarketTime { get; set; }

        public string Volume { get; set; }

        public string Shares { get; set; }

        public string AvgVol3m { get; set; }

        public string MarketCap { get; set; }

        public string Date { get; set; }

    }
}