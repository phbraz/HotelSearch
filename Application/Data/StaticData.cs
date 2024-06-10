namespace Application.Data;

public static class StaticData
{
    public const string FlightDataJson = @"
    [
        {
            ""id"": 1,
            ""airline"": ""First Class Air"",
            ""from"": ""MAN"",
            ""to"": ""TFS"",
            ""price"": 470,
            ""departureDate"": ""2023-07-01""
        },
        {
            ""id"": 2,
            ""airline"": ""Oceanic Airlines"",
            ""from"": ""MAN"",
            ""to"": ""AGP"",
            ""price"": 245,
            ""departureDate"": ""2023-07-01""
        },
        {
            ""id"": 3,
            ""airline"": ""Trans American Airlines"",
            ""from"": ""MAN"",
            ""to"": ""PMI"",
            ""price"": 170,
            ""departureDate"": ""2023-06-15""
        },
        {
            ""id"": 4,
            ""airline"": ""Trans American Airlines"",
            ""from"": ""LTN"",
            ""to"": ""PMI"",
            ""price"": 153,
            ""departureDate"": ""2023-06-15""
        },
        {
            ""id"": 5,
            ""airline"": ""Fresh Airways"",
            ""from"": ""MAN"",
            ""to"": ""PMI"",
            ""price"": 130,
            ""departureDate"": ""2023-06-15""
        },
        {
            ""id"": 6,
            ""airline"": ""Fresh Airways"",
            ""from"": ""LGW"",
            ""to"": ""PMI"",
            ""price"": 75,
            ""departureDate"": ""2023-06-15""
        },
        {
            ""id"": 7,
            ""airline"": ""Trans American Airlines"",
            ""from"": ""MAN"",
            ""to"": ""LPA"",
            ""price"": 125,
            ""departureDate"": ""2022-11-10""
        },
        {
            ""id"": 8,
            ""airline"": ""Fresh Airways"",
            ""from"": ""MAN"",
            ""to"": ""LPA"",
            ""price"": 175,
            ""departureDate"": ""2023-11-10""
        },
        {
            ""id"": 9,
            ""airline"": ""Fresh Airways"",
            ""from"": ""MAN"",
            ""to"": ""AGP"",
            ""price"": 140,
            ""departureDate"": ""2023-04-11""
        },
        {
            ""id"": 10,
            ""airline"": ""First Class Air"",
            ""from"": ""LGW"",
            ""to"": ""AGP"",
            ""price"": 225,
            ""departureDate"": ""2023-07-01""
        },
        {
            ""id"": 11,
            ""airline"": ""First Class Air"",
            ""from"": ""LGW"",
            ""to"": ""AGP"",
            ""price"": 155,
            ""departureDate"": ""2023-07-01""
        },
        {
            ""id"": 12,
            ""airline"": ""Trans American Airlines"",
            ""from"": ""MAN"",
            ""to"": ""AGP"",
            ""price"": 202,
            ""departureDate"": ""2023-10-25""
        }
    ]";
    
    public const string HotelDataJson = @"
    [
        {
            ""id"": 1,
            ""name"": ""Iberostar Grand Portals Nous"",
            ""arrival_date"": ""2022-11-05"",
            ""pricePerNight"": 100,
            ""localAirports"": [""TFS""],
            ""nights"": 7
        },
        {
            ""id"": 2,
            ""name"": ""Laguna Park 2"",
            ""arrival_date"": ""2022-11-05"",
            ""pricePerNight"": 50,
            ""localAirports"": [""TFS""],
            ""nights"": 7
        },
        {
            ""id"": 3,
            ""name"": ""Sol Katmandu Park & Resort"",
            ""arrival_date"": ""2023-06-15"",
            ""pricePerNight"": 59,
            ""localAirports"": [""PMI""],
            ""nights"": 14
        },
        {
            ""id"": 4,
            ""name"": ""Sol Katmandu Park & Resort"",
            ""arrival_date"": ""2023-06-15"",
            ""pricePerNight"": 59,
            ""localAirports"": [""PMI""],
            ""nights"": 14
        },
        {
            ""id"": 5,
            ""name"": ""Sol Katmandu Park & Resort"",
            ""arrival_date"": ""2023-06-15"",
            ""pricePerNight"": 60,
            ""localAirports"": [""PMI""],
            ""nights"": 10
        },
        {
            ""id"": 6,
            ""name"": ""Club Maspalomas Suites and Spa"",
            ""arrival_date"": ""2022-11-10"",
            ""pricePerNight"": 75,
            ""localAirports"": [""LPA""],
            ""nights"": 14
        },
        {
            ""id"": 7,
            ""name"": ""Club Maspalomas Suites and Spa"",
            ""arrival_date"": ""2022-09-10"",
            ""pricePerNight"": 76,
            ""localAirports"": [""LPA""],
            ""nights"": 14
        },
        {
            ""id"": 8,
            ""name"": ""Boutique Hotel Cordial La Peregrina"",
            ""arrival_date"": ""2022-10-10"",
            ""pricePerNight"": 45,
            ""localAirports"": [""LPA""],
            ""nights"": 7
        },
        {
            ""id"": 9,
            ""name"": ""Nh Malaga"",
            ""arrival_date"": ""2023-07-01"",
            ""pricePerNight"": 83,
            ""localAirports"": [""AGP""],
            ""nights"": 7
        },
        {
            ""id"": 10,
            ""name"": ""Barcelo Malaga"",
            ""arrival_date"": ""2023-07-05"",
            ""pricePerNight"": 45,
            ""localAirports"": [""AGP""],
            ""nights"": 10
        },
        {
            ""id"": 11,
            ""name"": ""Parador De Malaga Gibralfaro"",
            ""arrival_date"": ""2023-10-16"",
            ""pricePerNight"": 100,
            ""localAirports"": [""AGP""],
            ""nights"": 7
        },
        {
            ""id"": 12,
            ""name"": ""MS Maestranza Hotel"",
            ""arrival_date"": ""2023-07-01"",
            ""pricePerNight"": 45,
            ""localAirports"": [""AGP""],
            ""nights"": 14
        },
        {
            ""id"": 13,
            ""name"": ""Jumeirah Port Soller"",
            ""arrival_date"": ""2023-06-15"",
            ""pricePerNight"": 295,
            ""localAirports"": [""PMI""],
            ""nights"": 10
        }
    ]";
}