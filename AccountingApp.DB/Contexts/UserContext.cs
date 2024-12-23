using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingApp.DAL.Contexts
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=formation;Database=MakerHub;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // \"\" => CaseSensitive
            modelBuilder.Entity<User>().ToTable("\"User\"");
            
            // Properties.IsRequired
            
            modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).IsRequired();

            // Properties.Others

            modelBuilder.Entity<User>().Property(u => u.IsActive).HasDefaultValue(true);

            // Keys

            modelBuilder.Entity<User>().HasKey(u => u.Id);
            modelBuilder.Entity<User>().HasMany(u => u.Accounts)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId);


            /********************** NOTE **********************/
            // If the primary key name is Id, the methods below are not necessary.
            //modelBuilder.Entity<User>().Property(u => u.Id).ValueGeneratedOnAdd();

            //modelBuilder.Entity<User>().HasMany(u => u.Accounts)
            //    .WithOne(a => a.User)
            //    .HasForeignKey(a => a.UserId)
            //    .HasPrincipalKey(u => u.Id);
        }
    }
}
