using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Configuration;

public class Sailboat_Reservation : IEntityTypeConfiguration<Models.Sailboat_Reservation>
{
    public void Configure(EntityTypeBuilder<Models.Sailboat_Reservation> builder)
    {
        builder.ToTable("Sailboat_Reservation");
        builder
            .HasKey(x => new { x.IdSailboat, x.IdReservation });
        builder
            .HasOne(x => x.Sailboat)
            .WithMany(x => x.SailboatReservations)
            .HasForeignKey(x => x.IdSailboat);
        builder
            .HasOne(x => x.Reservation)
            .WithMany(x => x.SailboatReservations)
            .HasForeignKey(x => x.IdReservation);
    }
}