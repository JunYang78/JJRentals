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
                 Name = "Jackson Lee",
                 Password = "jacky123",
                 Address = "42 Punggol Street 62",
                 DateOfBirth = new DateTime(1989, 06, 26),
                 Email = "jackson@gmail.com",
                 ContactNo = "92554760",
                 HireDate = new DateTime(2007, 04, 01),
                 Position = "Fleet Manager",
                 OutletId = 1
             },

             new Staff
             {
                 Id = 2,
                 Name = "Jave Lau",
                 Password = "jave123",
                 Address = "82 Tampinies Street 23",
                 DateOfBirth = new DateTime(1993, 08, 06),
                 Email = "jave@gmail.com",
                 ContactNo = "96374434",
                 HireDate = new DateTime(2008, 03, 02),
                 Position = "Reservation Agent",
                 OutletId = 2
             }
             );
        }

       
    }
}
