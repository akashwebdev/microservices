using Mango.Services.Coupon.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.Coupon.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Coupons> Coupons { get; set; }

        /**Seeding Data*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupons>().HasData(new Coupons
            {
                CouponId = 1,
                CouponCode = "AMTEC",
                DiscountAmount = 10,
                MinAmount = 20,
            });
        }
    }
}
