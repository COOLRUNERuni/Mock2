using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Configuration;

public class Reservation : IEntityTypeConfiguration<Models.Reservation>
{
    public void Configure(EntityTypeBuilder<Models.Reservation> builder)
    {
        builder.ToTable("Reservation");
        builder
            .HasKey(x => x.IdReservation);
        builder
            .Property(x => x.IdReservation)
            .ValueGeneratedOnAdd()
            .IsRequired();
        builder
            .HasOne(x => x.Client)
            .WithMany(x => x.Reservations)
            .HasForeignKey(x => x.IdClient);
        builder
            .Property(x => x.DateFrom)
            .IsRequired();
        builder
            .Property(x => x.DateTo)
            .IsRequired();
        builder
            .HasOne(x => x.BoatStandard)
            .WithMany(x => x.Reservations)
            .HasForeignKey(x => x.IdBoatStandard);
        builder
            .Property(x => x.Capacity)
            .IsRequired();
        builder
            .Property(x => x.NumOfBoats)
            .IsRequired();
        builder
            .Property(x => x.Fulfilled)
            .IsRequired();
        builder
            .Property(x => x.Price);
        builder
            .Property(x => x.CancelReason)
            .HasMaxLength(200);
    }
}