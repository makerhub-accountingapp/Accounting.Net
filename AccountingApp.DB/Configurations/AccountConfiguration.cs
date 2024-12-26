using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountingApp.DB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingApp.DB.Configurations
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            /********** Tables **********/
            
            builder.ToTable("\"Account\"");

            /********** Properties.IsRequired **********/

            builder.Property(a => a.Name).IsRequired();

            /********** Properties.Others **********/

            builder.Property(a => a.Balance).HasDefaultValue(0);

            /********** Keys **********/

            builder.HasMany(a => a.Transactions)
                .WithOne(t => t.Account)
                .HasForeignKey(t => t.AccountId);
        }
    }
}
