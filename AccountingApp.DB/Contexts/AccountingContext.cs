using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DAL.Contexts;
using AccountingApp.DB.Configurations;
using AccountingApp.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingApp.DB.Contexts
{
    public class AccountingContext : DbContext
    {
        public AccountingContext(DbContextOptions<AccountingContext> options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Account> Account { get; set; } = null!;
        public DbSet<Transaction> Transaction { get; set; } = null!;
        public DbSet<Repetition> Repetition { get; set; } = null!;
        public DbSet<Detail> Detail { get; set; } = null!;
        public DbSet<Category> Category { get; set; } = null!;
        public DbSet<TransactionType> TransactionType { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());
            modelBuilder.ApplyConfiguration(new RepetitionConfiguration());
            modelBuilder.ApplyConfiguration(new DetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionTypeConfiguration());
        }
    }
}
