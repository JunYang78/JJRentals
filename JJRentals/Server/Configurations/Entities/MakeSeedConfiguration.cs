using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class MakeSeedConfiguration : IEntityTypeConfiguration<Manufacturer>
	{
		public void Configure(EntityTypeBuilder<Manufacturer> builder)
		{
			builder.HasData(
			 new Manufacturer
			 {
				 Id = 1,
				 Name = "BMW",
				 DateCreated = DateTime.Now,
				 DateUpdated = DateTime.Now,
				 CreatedBy = "System",
				 UpdatedBy = "System"
			 },

			 new Manufacturer
			 {
				 Id = 2,
				 Name = "Toyota",
				 DateCreated = DateTime.Now,
				 DateUpdated = DateTime.Now,
				 CreatedBy = "System",
				 UpdatedBy = "System"
			 }
			 );
		}
	}
}
