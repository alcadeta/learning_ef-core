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
            Console.WriteLine("Connection String: " + connStr);
            optionsBuilder.UseNpgsql(connStr ?? string.Empty);

        }
    }
}