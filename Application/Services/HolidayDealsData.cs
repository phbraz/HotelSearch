using Application.DTO;
using Application.Interfaces;

namespace Application.Services;

public class HolidayDealsData : IHolidaySearchRequest
{
    //I will handle the request here and return the data here. 
    public async Task<HolidaySearchResponse> FetchHolidaySearchAsync(HolidaySearchRequest request)
    {
        return new HolidaySearchResponse();
    }
}