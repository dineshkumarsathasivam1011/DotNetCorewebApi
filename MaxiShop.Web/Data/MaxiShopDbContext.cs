using MaxiShop.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace MaxiShop.Web.Data
{
    public class MaxiShopDbContext : DbContext
    {
        public MaxiShopDbContext(DbContextOptions<MaxiShopDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
    }
}
