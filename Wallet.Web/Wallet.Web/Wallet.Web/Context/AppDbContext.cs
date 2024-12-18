using Microsoft.EntityFrameworkCore;
using Wallet.Web.Shared.Models;

namespace Wallet.Web.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Carteira> Carteiras { get; set; }
    }
}
