using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FinanceScraper.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StockContext(
                serviceProvider.GetRequiredService<DbContextOptions<StockContext>>()))
                {
                    // Look for any stocks
                    if (context.Stock.Any())
                    {
                        return; // DB has been seeded
                    }
                    context.Stock.AddRange(
                        new Stock
                        {
                            Symbol = "AAPL",
                            LastPrice = "191.77",
                            Change = "+0.33",
                            PercentChange = "+0.17%",
                            Currency = "USD",
                            MarketTime = "3:11 PM EDT",
                            Volume  = "11.20M",
                            Shares = "-",
                            AvgVol3m = "25.21M",
                            MarketCap = "943.02B",
                            Date = "7/23/2018"
                        },
                        new Stock
                        {
                            Symbol = "CVS",
                            LastPrice = "66.1388",
                            Change = "+0.8788",
                            PercentChange = "+1.35%",
                            Currency = "USD",
                            MarketTime = "3:11 PM EDT",
                            Volume  = "4.02M",
                            Shares = "-",
                            AvgVol3m = "8.75MM",
                            MarketCap = "67.31",
                            Date = "7/23/2018"
                        },
                        new Stock
                        {
                            Symbol = "FB",
                            LastPrice = "210.6375",
                            Change = "+0.6975",
                            PercentChange = "+0.33%",
                            Currency = "USD",
                            MarketTime = "3:11 PM EDT",
                            Volume  = "12.04M",
                            Shares = "-",
                            AvgVol3m = "19.39M",
                            MarketCap = "612.42B",
                            Date = "7/23/2018"
                        },
                        new Stock
                        {
                            Symbol = "HAS",
                            LastPrice = "107.10",
                            Change = "+13.17",
                            PercentChange = "+14.04%",
                            Currency = "USD",
                            MarketTime = "3:11 PM EDT",
                            Volume  = "7.95M",
                            Shares = "-",
                            AvgVol3m = "1.29M",
                            MarketCap = "13.76B",
                            Date = "7/23/2018"
                        }
                    );
                    context.SaveChanges();
                }
        }
    }
}