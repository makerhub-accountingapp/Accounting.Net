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
    public class RepetitionConfiguration : IEntityTypeConfiguration<Repetition>
    {
        public void Configure(EntityTypeBuilder<Repetition> builder)
        {
            /********** Tables **********/

            builder.ToTable("\"Repetition\"");

            /********** Properties **********/

            builder.Property(r => r.Name).IsRequired();
            builder.Property(r => r.SetDate).HasDefaultValue(DateTime.Now);

            /********** Keys **********/

            builder.HasMany(r => r.Transactions)
                .WithOne(t => t.Repetition)
                .HasForeignKey(t => t.RepetitionId);
        }
    }
}
