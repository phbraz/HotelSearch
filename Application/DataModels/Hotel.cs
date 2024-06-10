namespace Application.DataModels;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal PricePerNight { get; set; }
    public List<string> LocalAirports { get; set; } //we could create a new model here to handle these local airports, but I don't want to overengineer things.
    public int Nights { get; set; }
}