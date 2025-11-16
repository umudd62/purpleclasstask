using Microsoft.EntityFrameworkCore;
using Purple_Puzzle.Models;

namespace Purple_Puzzle.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<TeamImage> TeamImages { get; set; }
        public DbSet<TeamInfo> TeamInfos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}