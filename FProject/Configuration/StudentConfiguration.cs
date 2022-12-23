using FinalProject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Student", "student");
        builder.Property(x => x.FirstName)
             .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.LastName)
             .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.StartYear)
             .IsRequired()
            .HasMaxLength(30);
        builder.Property(x => x.AddressId)
             .IsRequired()
            .HasMaxLength(50);
        builder.Property(x => x.PersonalId)
             .IsRequired()
            .HasMaxLength(20);
        builder.HasMany(x => x.StudentSubjects) 
            .WithOne(x => x.Student)
            .HasForeignKey(x => x.StudentId)
            .HasConstraintName("FK_StudentSubject_Student");
        builder.HasMany(x => x.Department)
           .WithOne(x => x.Schedule)
           .HasForeignKey(x => x.ScheduleId)
           .HasConstraintName("FK_Department_Schedule");
        builder.HasMany(x => x.StudentSubjects)
            .WithOne(x => x.Student)
            .HasForeignKey(x => x.StudentId)
            .HasConstraintName("FK_StudentSubject_Student");
        builder.Has

    }
}
