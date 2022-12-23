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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Room", "room");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description)
                .HasMaxLength(100);
            builder.Property(x => x.MaxNumberOfStudent)
                .HasMaxLength(50);
            builder.Property(x => x.IsFree)
                .HasMaxLength(50);


        }
    }
}
