using Application.DTO;
using Application.Interfaces;
using Application.Queries.HolidaySearch;
using Application.Services;
using MediatR;

namespace HotelSearchAPI.Configuration;

public static class ServiceConfiguration
{
    public static void ConfigurationService(IServiceCollection services)
    {
        //add our custom services here. I'm mainly using MediatR 
        services.AddSingleton<IHolidaySearchRequest, HolidayDealsData>();
        services.AddScoped<IRequestHandler<GetHolidayDealQuery, HolidaySearchResponse>, GetHolidayDealQueryHandler>();
    }
}