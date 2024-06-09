using System.Data.SqlTypes;

namespace WebApplication1.Models;

public class Sailboat
{
    public int IdSailboat { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public string Description { get; set; }
    public int IdBoatStandard { get; set; }
    public decimal Price { get; set; }
    public virtual BoatStandard BoatStandard { get; set; }
    public virtual ICollection<Sailboat_Reservation> SailboatReservations { get; set; }
}