using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group5Flight.Models.DomainModels;

namespace Group5Flight.Models.DataLayer.Configuration
{
    internal class ConfigureAirlines : IEntityTypeConfiguration<Airline>
    {
        public void Configure(EntityTypeBuilder<Airline> entity)
        {
            entity.HasData(
                new Airline { AirlineId = 1, Name = "Delta Airlines", ImageName = "delta.png" },
                new Airline { AirlineId = 2, Name = "United Airlines", ImageName = "united.png" },
                new Airline { AirlineId = 3, Name = "American Airlines", ImageName = "american.png" }
            );
        }
    }
}