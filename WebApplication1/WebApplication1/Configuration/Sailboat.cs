using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Configuration;

public class Sailboat: IEntityTypeConfiguration<Models.Sailboat>
{
    public void Configure(EntityTypeBuilder<Models.Sailboat> builder)
    {
        builder.ToTable("Sailboat");
        builder
            .HasKey(x => x.IdSailboat);
        builder
            .Property(x => x.IdSailboat)
            .ValueGeneratedOnAdd()
            .IsRequired();
        builder
            .Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Capacity)
            .IsRequired();
        builder
            .Property(x => x.Description)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .HasOne(x => x.BoatStandard)
            .WithMany(x => x.SailBoats)
            .HasForeignKey(x => x.IdBoatStandard);
        builder
            .Property(x => x.Price)
            .IsRequired();
    }
}