using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class ManufacturerSeedConfiguration : IEntityTypeConfiguration<Manufacturer>
	{
		public void Configure(EntityTypeBuilder<Manufacturer> builder)
		{
			builder.HasData(
			 new Manufacturer
			 {
				 Id = 1,
				 Name = "BMW",
				 ContactNo = "91234567",
				 Email = "BMW@gmail.com"
			 },

			 new Manufacturer
			 {
				 Id = 2,
				 Name = "Toyota",
				 ContactNo = "81234567",
				 Email = "Toyota@yahoo.com"
			 },

			 new Manufacturer
			 {
                 Id = 3,
                 Name = "Honda",
                 ContactNo = "87654321",
                 Email = "Honda@yahoo.com"

             }
			 );
		}
	}
}
