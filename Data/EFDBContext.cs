using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EFDBContext : DbContext
    {
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Team> Teams { get; set; }
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Footballer>
            (builder =>
            {
                builder.Property(x => x.FootballerID).ValueGeneratedOnAdd();
                builder.Property(x => x.Name).HasMaxLength(100).HasColumnName("FirstName");
                builder.Property(x => x.Surname).HasMaxLength(100).HasColumnName("SecondName");
                builder.Property(x => x.Sex);
                builder.Property(x => x.BornDate);
                builder.Property(x => x.TeamId);
                builder.Property(x => x.Country).HasMaxLength(100);
            }
            );

            modelBuilder.Entity<Team>
            (builder =>
            {
                builder.Property(x => x.TeamId).ValueGeneratedOnAdd();
                builder.Property(x => x.TeamName).HasMaxLength(100);
            }
            );
        }
    }
}
