using Microsoft.EntityFrameworkCore;

namespace FinanceScraper.Models
{
    public class StockContext : DbContext
    {
        public StockContext (DbContextOptions<StockContext> options)
        : base(options)
        {
        }

        public DbSet<FinanceScraper.Models.Stock> Stock { get; set; }
    }
}