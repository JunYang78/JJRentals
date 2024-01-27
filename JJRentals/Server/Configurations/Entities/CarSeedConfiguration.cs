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
				 CarPlate = "S12345G",
				 Year  = 2010,
				 CarRentPerDay = 100,
				 CarRentPerHour = 20,
				 Colour = "Blue",
				 Availability = true,
				 OutletId = 1,
				 ModelId = 2

			 },

			 new Car
			 {
				 Id = 2,
                 CarPlate = "S67891Y",
                 Year = 2010,
                 CarRentPerDay = 90,
                 CarRentPerHour = 10,
                 Colour = "Blue",
                 Availability = true,
                 OutletId = 1,
                 ModelId = 6
             }
			 );
		}
	}
}
