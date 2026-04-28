using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group5Flight.Models.DomainModels;

namespace Group5Flight.Models.DataLayer.Configuration
{
    internal class ConfigureFlights : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> entity)
        {
            entity.HasData(
                new Flight
                {
                    FlightId = 1,
                    FlightCode = "DL1001",
                    From = "New York",
                    To = "Chicago",
                    Date = DateTime.Today.AddDays(1),
                    DepartureTime = DateTime.Today.AddDays(1).AddHours(8),
                    ArrivalTime = DateTime.Today.AddDays(1).AddHours(10).AddMinutes(30),
                    CabinType = "Economy",
                    Emission = "Low",
                    AircraftType = "Airbus 320 Family",
                    Price = 199.99m,
                    AirlineId = 1
                },
                new Flight
                {
                    FlightId = 2,
                    FlightCode = "DL2002",
                    From = "Chicago",
                    To = "Los Angeles",
                    Date = DateTime.Today.AddDays(2),
                    DepartureTime = DateTime.Today.AddDays(2).AddHours(10),
                    ArrivalTime = DateTime.Today.AddDays(2).AddHours(13),
                    CabinType = "Business",
                    Emission = "Medium",
                    AircraftType = "Boeing 737 Family",
                    Price = 499.99m,
                    AirlineId = 1
                },
                new Flight
                {
                    FlightId = 3,
                    FlightCode = "UA101",
                    From = "New York",
                    To = "Miami",
                    Date = DateTime.Today.AddDays(1),
                    DepartureTime = DateTime.Today.AddDays(1).AddHours(9),
                    ArrivalTime = DateTime.Today.AddDays(1).AddHours(12),
                    CabinType = "Economy Plus",
                    Emission = "Low",
                    AircraftType = "Airbus 320 Family",
                    Price = 249.99m,
                    AirlineId = 2
                },
                new Flight
                {
                    FlightId = 4,
                    FlightCode = "UA202",
                    From = "Chicago",
                    To = "Dallas",
                    Date = DateTime.Today.AddDays(3),
                    DepartureTime = DateTime.Today.AddDays(3).AddHours(7),
                    ArrivalTime = DateTime.Today.AddDays(3).AddHours(9).AddMinutes(30),
                    CabinType = "Basic Economy",
                    Emission = "High",
                    AircraftType = "Boeing 737 Family",
                    Price = 149.99m,
                    AirlineId = 2
                },
                new Flight
                {
                    FlightId = 5,
                    FlightCode = "AA303",
                    From = "Los Angeles",
                    To = "Seattle",
                    Date = DateTime.Today.AddDays(1),
                    DepartureTime = DateTime.Today.AddDays(1).AddHours(14),
                    ArrivalTime = DateTime.Today.AddDays(1).AddHours(16).AddMinutes(30),
                    CabinType = "Economy",
                    Emission = "Medium",
                    AircraftType = "Airbus 320 Family",
                    Price = 179.99m,
                    AirlineId = 3
                },
                new Flight
                {
                    FlightId = 6,
                    FlightCode = "AA404",
                    From = "New York",
                    To = "Miami",
                    Date = DateTime.Today.AddDays(2),
                    DepartureTime = DateTime.Today.AddDays(2).AddHours(6),
                    ArrivalTime = DateTime.Today.AddDays(2).AddHours(9),
                    CabinType = "Business",
                    Emission = "Low",
                    AircraftType = "Boeing 737 Family",
                    Price = 399.99m,
                    AirlineId = 3
                },
                new Flight
                {
                    FlightId = 7,
                    FlightCode = "DL3003",
                    From = "Seattle",
                    To = "Chicago",
                    Date = DateTime.Today.AddDays(3),
                    DepartureTime = DateTime.Today.AddDays(3).AddHours(12),
                    ArrivalTime = DateTime.Today.AddDays(3).AddHours(16),
                    CabinType = "Economy",
                    Emission = "Medium",
                    AircraftType = "Airbus 320 Family",
                    Price = 299.99m,
                    AirlineId = 1
                },
                new Flight
                {
                    FlightId = 8,
                    FlightCode = "UA505",
                    From = "Dallas",
                    To = "Los Angeles",
                    Date = DateTime.Today.AddDays(1),
                    DepartureTime = DateTime.Today.AddDays(1).AddHours(15),
                    ArrivalTime = DateTime.Today.AddDays(1).AddHours(17).AddMinutes(30),
                    CabinType = "Economy Plus",
                    Emission = "Low",
                    AircraftType = "Airbus 320 Family",
                    Price = 229.99m,
                    AirlineId = 2
                }
            );
        }
    }
}