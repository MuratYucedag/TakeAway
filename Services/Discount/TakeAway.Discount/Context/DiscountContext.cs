using Microsoft.EntityFrameworkCore;
using TakeAway.Discount.Entites;

namespace TakeAway.Discount.Context
{
    public class DiscountContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial Catalog=TakeAwayDiscountDb;integrated Security=true");
        }
        public DbSet<Coupon> Coupons { get; set; }
    }
}
