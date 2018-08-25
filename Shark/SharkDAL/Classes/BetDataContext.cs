using System.Data.Entity;

namespace SharkDAL.Classes
{
    public class BetDataContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Match> Matches { get; set; }
        public DbSet<Season> Seasons { get; set; }
    }
}