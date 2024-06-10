using Application.DataModels;

namespace Application.DTO;

public class HolidaySearchResponse
{
    public List<Flight> Flights { get; set; }
    public List<Hotel> Hotels { get; set; }
}