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
                 Name = "JJRentalHorizon",
                 Location = "SengKang",
                 ContactNo = "63234590",
                 Email = "JJRentalHorizon@gmail.com"
             },

             new Outlet
             {
                 Id = 2,
                 Name = "JJRentalMirage",
                 Location = "BoonLay",
                 ContactNo = "67885643",
                 Email = "JJRentalMirage@yahoo.com"
             },

             new Outlet
             {
                 Id = 3,
                 Name = "JJRentalDestiny",
                 Location = "Tampinies",
                 ContactNo = "64523474",
                 Email = "JJRentalDestiny@yahoo.com"

             }
             );
        }
    }
}
