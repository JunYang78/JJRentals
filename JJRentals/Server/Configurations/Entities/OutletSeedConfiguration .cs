using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class OutletSeedConfiguration : IEntityTypeConfiguration<Outlet>
	{
		public void Configure(EntityTypeBuilder<Outlet> builder)
		{
			builder.HasData(
			 new Outlet
			 {
				 Id = 1,
				 Name = "JJRentals Bedok",
				 Location = "Bedok",
				 ContactNo = " 96357925",
				 Email = "jjbedok@gmail.com"

			 }

			 );
		}
	}
}
