using Application.DTO;
using Application.Interfaces;
using MediatR;

namespace Application.Queries.HolidaySearch;

public class GetHolidayDealQuery : IRequest<HolidaySearchResponse>
{
    public HolidaySearchRequest Filters { get; set; }
};

public class GetHolidayDealQueryHandler(IHolidaySearchRequest holidaySearchRequest)
    : IRequestHandler<GetHolidayDealQuery, HolidaySearchResponse>
{
    public async Task<HolidaySearchResponse> Handle(GetHolidayDealQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var holidaySearchData = await holidaySearchRequest.FetchHolidaySearchAsync(request.Filters);
            return holidaySearchData;
        }
        catch (Exception e)
        {
            throw e;
        }
    }
}