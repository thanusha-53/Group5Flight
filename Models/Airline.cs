using System.Collections.Generic;

namespace Group5Flight.Models
{
    public class Airline
    {
        public int Id { get; set; }               // Primary key
        public string Name { get; set; } = "";         // Airline name
        public string ImageName { get; set; }  = "";   // Airline logo filename (e.g., "airindia.png")

        // Navigation property
        public List<Flight> Flights { get; set; } = new List<Flight>();
    }
}