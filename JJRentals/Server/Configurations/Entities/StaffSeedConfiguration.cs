using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
	{
		public void Configure(EntityTypeBuilder<Staff> builder)
		{
			builder.HasData(
			 new Staff
			 {
				 Id = 1,
				 Name = "Peter Ng",
				 Password = "peter123",
                 DateOfBirth = new DateTime(2000, 08, 26),
				 Email = "john@gmail.com",
                 ContactNo = "98854760",
                 Address = "81 Bedok Street 21",
				 HireDate = new DateTime(2019, 08, 13),
				 Position = "Admin",
				 OutletId = 1
			 }
			 );
		}
	}
}
