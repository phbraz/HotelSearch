using Application.Data;
using Application.DataModels;
using Newtonsoft.Json;

namespace Application.Helpers;

public static class Data
{
    public static List<Flight> DeserializeFlights()
    {
        var flights = JsonConvert.DeserializeObject<List<Flight>>(StaticData.FlightDataJson);
        return flights;
    }

    public static List<Hotel> DeserializeHotels()
    {
        var hotels = JsonConvert.DeserializeObject<List<Hotel>>(StaticData.HotelDataJson);
        return hotels;
    }

    public static List<AirportCode> FindAllAirportCodes()
    {
        var flights = DeserializeFlights();
        
        var airportsFrom = flights.Select(x => x.From);
        var airportsTo = flights.Select(x => x.To);
        
        var airportCodes = airportsFrom.Union(airportsTo).Distinct().Select(x => new AirportCode { Code = x }).ToList();
        
        return airportCodes;
    }

    public static List<AirportCode> LondonAirportsCodes()
    {
        var londonAirports = new List<AirportCode>
        {
            new AirportCode() { Code = "LTN" },
            new AirportCode() { Code = "LGW" }
        };

        return londonAirports;
    }
}