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
    public class SemesterConfiguration : IEntityTypeConfiguration<Semester>
    {
        public void Configure(EntityTypeBuilder<Semester> builder)
        {
            builder.ToTable("Semester", "semester");
            builder.Property(x => x.Name)
                .HasMaxLength(50);
            builder.Property(x => x.AvaliableGpa)
                .HasMaxLength(30);
            builder.Property(x => x.StartDate)
                .HasMaxLength(30);
            builder.Property(x => x.EndDate)
                .HasMaxLength(30);
        }
    }
}
