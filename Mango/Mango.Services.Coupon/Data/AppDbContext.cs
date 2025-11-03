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
    }
}
