using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Configuration;

public class ClientCategory: IEntityTypeConfiguration<Models.ClientCategory>
{

    public void Configure(EntityTypeBuilder<Models.ClientCategory> builder)
    {
        builder
            .ToTable("ClientCategory");
        builder
            .HasKey(x => x.IdClientCategory);
        builder
            .Property(x => x.IdClientCategory)
            .ValueGeneratedOnAdd()
            .IsRequired();
        builder
            .Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.DiscountPerc)
            .IsRequired();
    }
}