namespace Application.DTO;

public class HolidaySearchRequest
{
    public string DepartingFrom { get; set; }
    public string TravellingTo { get; set; }
    public DateTime DepartureDate { get; set; }
    public int Duration { get; set; } //Days
}