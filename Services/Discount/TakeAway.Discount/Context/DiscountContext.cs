using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TakeAway.Discount.Entites;

namespace TakeAway.Discount.Context
{
    public class DiscountContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public DiscountContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R7AR1ND;initial Catalog=TakeAwayDiscountDb;integrated Security=true");
        }
        public DbSet<Coupon> Coupons { get; set; }
    }
}
