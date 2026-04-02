using System;
using System.Collections.Generic;

namespace Group5Flight.Models   
{
    public class HomeViewModel
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // Filters
        public string From { get; set; } = "";
        public string To { get; set; } = "";
        public DateTime? DepartureDate { get; set; }
        public string CabinType { get; set; } = "";

        public int? AirlineId { get; set; }
        public List<Airline> Airlines { get; set; } = new List<Airline>();


        // Dropdown data
        public List<string> FromCities { get; set; } = new List<string>();
        public List<string> ToCities { get; set; }= new List<string>();
        public List<string> CabinTypes { get; set; }= new List<string>();
    }
}