namespace WebApplication1.Models;

public class Sailboat_Reservation
{
    public int IdSailboat { get; set; }
    public int IdReservation { get; set; }
    public virtual Sailboat Sailboat { get; set; }
    public virtual Reservation Reservation { get; set; }
}