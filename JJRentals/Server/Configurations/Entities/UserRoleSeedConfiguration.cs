﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
	public class UserRoleSeedConfiguration :
	IEntityTypeConfiguration<IdentityUserRole<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
		{
			builder.HasData(
				new IdentityUserRole<string>
				{
					RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
					UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
				},

				new IdentityUserRole<string>
				{
					RoleId = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
					UserId = "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1"
                }
			);
		}
	}
}
