using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
	{
		public void Configure(EntityTypeBuilder<IdentityRole> builder)
		{
			builder.HasData(
			new IdentityRole
			{
				Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
				Name = "Administrator",
				NormalizedName = "ADMINISTRATOR"
			},
			new IdentityRole
			{
				Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
				Name = "User",
				NormalizedName = "USER"
			},
			new IdentityRole
			{
				Id = "3895a3c6-c0b1-4dd2-b518-2d0f861896e9",
				Name = "Customer",
				NormalizedName = "CUSTOMER"
            }
			);
		}
	}
}
