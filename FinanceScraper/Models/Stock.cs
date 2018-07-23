using System.ComponentModel.DataAnnotations;

namespace FinanceScraper.Models
{
    public class Stock
    {
        public int ID { get; set; }
        public string Symbol { get; set; }
        [Display(Name = "Last Price")]
        public string LastPrice { get; set; }

        public string Change { get; set; }

        [Display(Name = "% Chg")]
        public string PercentChange { get; set; }

        public string Currency { get; set; }

        [Display(Name = "Market Time")]
        public string MarketTime { get; set; }

        public string Volume { get; set; }

        public string Shares { get; set; }

        [Display(Name = "Avg Vol (3m)")]
        public string AvgVol3m { get; set; }

        [Display(Name = "Market Cap")]
        public string MarketCap { get; set; }

        public string Date { get; set; }

    }
}