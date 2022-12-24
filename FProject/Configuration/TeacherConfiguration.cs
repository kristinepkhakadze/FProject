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
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher", "teacher");
            builder.Property(x => x.FirstName)
                .HasMaxLength(50);
            builder.Property(x => x.LastName)
                .HasMaxLength(50);
            builder.Property(x => x.PersonalId)
               .HasMaxLength(20);
        }
    }
}
