using FinalProject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Configuration
{
    public class BalanceConfiguration : IEntityTypeConfiguration<Balance>
    {
        public void Configure(EntityTypeBuilder<Balance> builder)
        {
            builder.ToTable("Balance", "balance");
            
            builder.Property(x => x.Amount)
           .HasColumnType("decimal(18,2)");
            builder.Property(x => x.Debth)
                .HasColumnType("decimal(18,2");

            builder.Property(x => x.SemesterId);
            builder.Property(x => x.StudentId);
        }
    }
}
