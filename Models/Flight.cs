using System;

namespace Group5Flight.Models
{
    public class Flight
    {
        public int FlightId { get; set; }         // Primary key
        public string From { get; set; } = "";          // Departure city
        public string To { get; set; }  ="";
                  // Arrival city
        public DateTime Date { get; set; }        // Flight date
        public string CabinType { get; set; } ="";    // Cabin type (Economy, Business, etc.)
        
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }

        public decimal Price { get; set; }        // Ticket price
        public string Emission { get; set; }  = "" ;  // Carbon emission info

        // Foreign key
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }  = new Airline();  // Navigation property
    }
}