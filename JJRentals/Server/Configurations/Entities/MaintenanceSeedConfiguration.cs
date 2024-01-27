using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
    public class MaintenanceSeedConfiguration : IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {
            builder.HasData(
             new Maintenance
             {
                 Id = 1,
                 SentDate = new DateTime(2024, 01, 15),
                 ReturnDate = new DateTime(2024, 01, 22),
                 ServiceProvider = "Best Maintenance Co",
                 PartsAffected = "Brakes, Oil filter",
                 Cost = 200.00m,
                 StaffId = 1,
                 CarId = 1
             },

             new Maintenance
             {
                 Id = 2,
                 SentDate = new DateTime(2024, 02, 10),
                 ServiceProvider = "Quick Fix Mechanics",
                 PartsAffected = "Air filter, Headlights",
                 Cost = 150.00m,
                 StaffId = 2, // Another existing Staff 
                 CarId = 2
             }


             );
        }
    }
}