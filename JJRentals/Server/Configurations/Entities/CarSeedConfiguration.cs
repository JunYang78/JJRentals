using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
    public class CarSeedConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(
             new Car
             {
                 Id = 1,
                 CarPlate = "ABC123",
                 Year = 2020,
                 CarRentPerHour = 15.99m,
                 CarRentPerDay = 79.99m,
                 Colour = "Blue",
                 Availability = true,
                 OutletId = 1,
                 ModelId = 1
             },

             new Car
             {
                 Id = 2,
                 CarPlate = "XYZ789",
                 Year = 2019,
                 CarRentPerHour = 12.99m,
                 CarRentPerDay = 69.99m,
                 Colour = "Red",
                 Availability = false,
                 OutletId = 2,
                 ModelId = 2
             },

             new Car
             {
                 Id = 3,
                 CarPlate = "DEF456",
                 Year = 2021,
                 CarRentPerHour = 18.99m,
                 CarRentPerDay = 89.99m,
                 Colour = "Green",
                 Availability = true,
                 OutletId = 3,
                 ModelId = 3

             }
             );
        }
    }
}