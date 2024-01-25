using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class CustomerSeedConfiguration : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder)
		{
			builder.HasData(
			 new Customer
			 {
				 Id = 1,
				 Name = "John Tan",
				 Password = "john123",
				 Address = "81 Bedok Street 21",
				 DateOfBirth = new DateTime(2000, 08, 26),
				 Email = "john@gmail.com",
                 ContactNo = "98854760",
				 DriverLicenseNo = "S7654321Z",
                 LicenseIssueDate = new DateTime(2018, 04, 01),
				 LicenseExpDate = new DateTime(2099, 03, 31),
                 DateCreated = DateTime.Now,
				 DateUpdated = DateTime.Now,
				 CreatedBy = "System",
				 UpdatedBy = "System"
			 },

			 new Customer
			 {
                 Id = 2,
                 Name = "Mary Lim",
				 Password = "mary123",
                 Address = "203 Tampines Street 24",
                 DateOfBirth = new DateTime(1997, 06, 06),
                 Email = "mary@gmail.com",
                 ContactNo = "96377946",
                 DriverLicenseNo = "S1234567A",
                 LicenseIssueDate = new DateTime(2010, 07, 03),
                 LicenseExpDate = new DateTime(2099, 03, 31),
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 UpdatedBy = "System"
             }
			 );
		}
	}
}
