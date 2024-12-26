using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DAL.Contexts;
using AccountingApp.DB.Models;
using Microsoft.EntityFrameworkCore;

namespace AccountingApp.DB.Contexts
{
    public class AccountingContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
