using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JJRentals.Shared.Domain;

namespace JJRentals.Server.Configurations.Entities
{
	public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
	{
		public void Configure(EntityTypeBuilder<Model> builder)
		{
            builder.HasData(
                new Model
                {
                    Id = 1,
                    Name = "BMW X7",
                    DateCreated = new DateTime(2018, 10, 17),
                    SeatCapacity = 5,
                    FuelType = "Petrol",
                    TransmissionType = "Automatic",
                    ManufacturerId = 1
                },
                new Model
                {
                    Id = 2,
                    Name = "BMW X5",
                    DateCreated = new DateTime(2006, 07, 01),
                    SeatCapacity = 5,
                    FuelType = "Diesel",
                    TransmissionType = "Automatic",
                    ManufacturerId = 1
                },
                new Model
                {
                    Id = 3,
                    Name = "BMW Z4",
                    DateCreated = new DateTime(2002, 03, 15),
                    SeatCapacity = 2,
                    FuelType = "Petrol",
                    TransmissionType = "Manual",
                    ManufacturerId = 1
                },

                // Honda Models
                new Model
                {
                    Id = 4,
                    Name = "Honda Civic",
                    DateCreated = new DateTime(2013, 04, 11),
                    SeatCapacity = 5,
                    FuelType = "Petrol",
                    TransmissionType = "Manual",
                    ManufacturerId = 3
                },
                new Model
                {
                    Id = 5,
                    Name = "Honda Accord",
                    DateCreated = new DateTime(2011, 11, 11),
                    SeatCapacity = 5,
                    FuelType = "Hybrid",
                    TransmissionType = "Automatic",
                    ManufacturerId = 3
                },
                new Model
                {
                    Id = 6,
                    Name = "Honda CR-V",
                    DateCreated = new DateTime(2015, 05, 08),
                    SeatCapacity = 5,
                    FuelType = "Diesel",
                    TransmissionType = "Automatic",
                    ManufacturerId = 3
                },

                // Toyota Models
                new Model
                {
                    Id = 7,
                    Name = "Toyota Corolla",
                    DateCreated = new DateTime(2020, 06, 20),
                    SeatCapacity = 5,
                    FuelType = "Petrol",
                    TransmissionType = "Automatic",
                    ManufacturerId = 2
                },
                new Model
                {
                    Id = 8,
                    Name = "Toyota Camry",
                    DateCreated = new DateTime(2019, 08, 27),
                    SeatCapacity = 5,
                    FuelType = "Hybrid",
                    TransmissionType = "Automatic",
                    ManufacturerId = 2
                },
                new Model
                {
                    Id = 9,
                    Name = "Toyota RAV4",
                    DateCreated = new DateTime(2010, 02, 17),
                    SeatCapacity = 5,
                    FuelType = "Petrol",
                    TransmissionType = "Manual",
                    ManufacturerId = 2
                }
			);
		}
	}
}
