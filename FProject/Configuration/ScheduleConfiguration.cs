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
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.ToTable("Schedule", "schedule");
            builder.Property(x => x.StartTime)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(x => x.EndTime)
                .IsRequired()
                .HasMaxLength(30);
            builder.HasMany(x => x.Semester)
            .WithOne(x => x.Student)
            .HasForeignKey(x => x.StudentId)
            .HasConstraintName("FK_Semester_Student");
        }
    }
}