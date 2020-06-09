using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Soccer.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soccer.Web.Data
{
    public class DataContext : IdentityDbContext<UserEntity>
    {
        public DataContext(DbContextOptions<DataContext>options) : base(options)
        {
        }

        public DbSet<GroupDetailEntity> GroupDetails { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<MatchEntity> Matches { get; set; }
        public DbSet<PredictionEntity> Predictions { get; set; }
        public DbSet<Team> Teams { get; set; }

        internal object Include(Func<object, object> p)
        {
            throw new NotImplementedException();
        }

        public DbSet<TournamentEntity> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Team>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
