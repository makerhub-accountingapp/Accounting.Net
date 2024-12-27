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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            /********** Tables **********/

            builder.ToTable("Transaction");

            /********** Properties **********/

            builder.Property(t => t.Name).IsRequired();
            builder.Property(t => t.RepetitionId).IsRequired();

            /********** Keys **********/

            builder.HasMany(t => t.Details)
                .WithOne(d => d.Transaction)
                .HasForeignKey(d => d.TransactionId);
        }
    }
}
