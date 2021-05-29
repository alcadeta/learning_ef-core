using System;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp.Entities
{
    public class ActorDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connStr = Environment.GetEnvironmentVariable("postgresconnstr");
            optionsBuilder.UseNpgsql(connStr ?? string.Empty);

        }
    }
}