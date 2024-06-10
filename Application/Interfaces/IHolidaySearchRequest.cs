using Application.DTO;

namespace Application.Interfaces;

public interface IHolidaySearchRequest
{
    Task<HolidaySearchResponse> FetchHolidaySearchAsync(HolidaySearchRequest request);
}