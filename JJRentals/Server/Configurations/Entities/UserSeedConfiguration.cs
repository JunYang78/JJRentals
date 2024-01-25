﻿using JJRentals.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using JJRentals.Server.Models;

namespace JJRentals.Server.Configurations.Entities
{
	public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			var hasher = new PasswordHasher<ApplicationUser>();
			builder.HasData(
				new ApplicationUser
				{
					Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
					Email = "admin@localhost.com",
					NormalizedEmail = "ADMIN@LOCALHOST.COM",
					FirstName = "Admin",
					LastName = "User",
					UserName = "admin@localhost.com",
					NormalizedUserName = "ADMIN@LOCALHOST.COM",
					PasswordHash = hasher.HashPassword(null, "P@ssword1")
				},

				new ApplicationUser
				{
					Id = "d925e8b3-4a17-4c69-bb0a-9f2e6a86f5d1",
					Email = "user@localhost.com",
					NormalizedEmail = "USER@LOCALHOST.COM",
					FirstName = "User",
					LastName = "Default",
					UserName = "user@localhost.com",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1")
                }
				);
		}
	}
}
