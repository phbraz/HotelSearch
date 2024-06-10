using Application.DTO;
using Application.Queries.HolidaySearch;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HotelSearchAPI.Controllers;

[Microsoft.AspNetCore.Components.Route("HolidaySearch")]
public class HolidaySearchController(IMediator mediator) : MainBase(mediator)
{
    [HttpPost("FetchHolidayDeals")]
    public async Task<HolidaySearchResponse> FetchHolidayDeals([FromBody] GetHolidayDealQuery query, CancellationToken token)
        => await SendQuery<GetHolidayDealQuery, HolidaySearchResponse>(query, token);
}