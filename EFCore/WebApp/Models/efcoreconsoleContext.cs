using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApp.Models
{
    public partial class efcoreconsoleContext : DbContext
    {
        public efcoreconsoleContext()
        {
        }

        public efcoreconsoleContext(DbContextOptions<efcoreconsoleContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actor> Actors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connStr = Environment.GetEnvironmentVariable("postgresconnstr");
                optionsBuilder.UseNpgsql(connStr ?? string.Empty);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
