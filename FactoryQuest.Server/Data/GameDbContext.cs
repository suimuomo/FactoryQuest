using FactoryQuest.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace FactoryQuest.Server.Data
{
    public class GameDbContext : DbContext
    {
        public GameDbContext(DbContextOptions<GameDbContext> options)
            : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}