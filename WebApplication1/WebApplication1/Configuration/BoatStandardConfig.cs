using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration;

public class BoatStandardConfig : IEntityTypeConfiguration<BoatStandard>
{
    public void Configure(EntityTypeBuilder<BoatStandard> builder)
    {
        builder
            .ToTable("BoardStandard");
        builder
            .HasKey(x => x.IdBoatStandard);
        builder
            .Property(x => x.IdBoatStandard)
            .ValueGeneratedOnAdd()
            .IsRequired();
        builder
            .Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Level)
            .IsRequired();
    }
}