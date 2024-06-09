using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Configuration;

public class Client: IEntityTypeConfiguration<Models.Client>
{
    public void Configure(EntityTypeBuilder<Models.Client> builder)
    {
        builder
            .ToTable("Client");
        builder
            .HasKey(x => x.IdClient);
        builder
            .Property(x => x.IdClient)
            .ValueGeneratedOnAdd()
            .IsRequired();
        builder
            .Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.LastName)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Birthday)
            .IsRequired();
        builder
            .Property(x => x.Pesel)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .Property(x => x.Email)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .HasOne(x => x.ClientCategory)
            .WithMany(x => x.Clients)
            .HasForeignKey(x => x.IdClientCategory);
        
    }
}