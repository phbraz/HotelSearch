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
}