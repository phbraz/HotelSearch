using Application.Data;
using Application.DataModels;
using Application.DTO;
using Application.Interfaces;
using Newtonsoft.Json;

namespace Application.Services;

public class HolidayDealsData : IHolidaySearchRequest
{
    private readonly Dictionary<string, List<AirportCode>> airPortDictionary = new Dictionary<string, List<AirportCode>>()
    {
        { "Any London Airport", Helpers.Data.LondonAirportsCodes() },
        { "Any Airport", Helpers.Data.FindAllAirportCodes() }
    };
    
    //I will handle the request here and return the data. 
    public async Task<HolidaySearchResponse> FetchHolidaySearchAsync(HolidaySearchRequest request)
    {
        var flight = await FindBestFlight(request);
        var hotel = await FindBestHotel(request);
        var totalPrice = await CalculateTotalPrice(flight, hotel, request.Duration);

        var response = new HolidaySearchResponse()
        {
            Flight = flight,
            Hotel = hotel,
            TotalPrice = totalPrice
        };
        
        return response;
    }

    private async Task<Flight> FindBestFlight(HolidaySearchRequest request)
    {
        var airportsToSearch = new List<AirportCode>();
        var departingFrom = request.DepartingFrom;
        
        if (airPortDictionary.TryGetValue(departingFrom, out var airportCodes ))
        {
            airportsToSearch = airportCodes;
        }
        else
        {
            airportsToSearch = new List<AirportCode>
            {
                new AirportCode() { Code = departingFrom }
            };
        }
        
        var flightsData = await FlightsDataAsync();
        var filteredFlight =  flightsData
            .Where(x => airportsToSearch.Select(a => a.Code).Contains(x.From) &&
                        x.To == request.TravellingTo &&
                        x.DepartureDate.ToString("dd-MM-yyyy") == request.DepartureDate.ToString("dd-MM-yyyy"))
            .OrderBy(x => x.Price)
            .First();

        return filteredFlight;
    }

    private async Task<Hotel> FindBestHotel(HolidaySearchRequest request)
    {
        var hotelsData = await HotelsDataAsync();
        var filteredHotel = hotelsData
            .Where(x => x.LocalAirports.Contains(request.TravellingTo)
                        && x.Nights == request.Duration)
            .OrderBy(x => x.PricePerNight)
            .First();

        return filteredHotel;
    }

    private async Task<decimal> CalculateTotalPrice(Flight flight, Hotel hotel, int duration)
    {
        return flight.Price + (duration * hotel.PricePerNight);
    }

    private Task<List<Flight>> FlightsDataAsync()
    {
        var flightsData = JsonConvert.DeserializeObject<List<Flight>>(StaticData.FlightDataJson);
        return Task.FromResult(flightsData);
    }

    private Task<List<Hotel>> HotelsDataAsync()
    {
        var hotelsData = JsonConvert.DeserializeObject<List<Hotel>>(StaticData.HotelDataJson);
        return Task.FromResult(hotelsData);
    }
    
}