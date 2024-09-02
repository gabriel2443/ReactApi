using FootballersAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballersAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
    }
}