using BestShop.Models;
using Microsoft.EntityFrameworkCore;

namespace BestShop.Data;

public class BestShopDbContext : DbContext
{
    public BestShopDbContext(DbContextOptions<BestShopDbContext> options) : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; } = null!;
}
