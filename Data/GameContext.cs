using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ADO_NET_7.DataAccess
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\\mssqllGamedb;Database=GameDb;Trusted_Connection=True");
        }
    }
}
