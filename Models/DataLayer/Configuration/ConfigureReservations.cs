using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group5Flight.Models.DomainModels;

namespace Group5Flight.Models.DataLayer.Configuration
{
    internal class ConfigureReservations : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> entity)
        {
        }
    }
}