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
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("department", "department");
            builder.Property(x => x.Name)
                .HasMaxLength(50);
            builder.Property(x => x.CurrAmount)
                .HasMaxLength(255);
            builder.Property(x => x.MaxNumofStudent)
                .HasMaxLength(10);
          
            builder.HasMany(x => x.Student)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId);
                .HasConstraintName("Fk_Student_Demartment")
               // .IsRequired();
            builder.HasMany(x => x.Teacher)
                .WithOne(x => x.Department)
                .HasForeignKey(x => x.DepartmentId);
                .HasConstraintName("Fk_Teacher_Demartment")
        }
    }
}
