using Application.DataModels;

namespace Application.DTO;

public class HolidaySearchResponse
{
    public Flight Flight { get; set; }
    public Hotel Hotel { get; set; }
}