using JJRentals.Shared.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JJRentals.Server.Configurations.Entities
{
    public class ImageSeedConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = 1,
                    ImgFileURL = "https://example.com/images/car1.jpg", // Example URL for the image file
                    CarId = 1
                },
                new Image
                {
                    Id = 2,
                    ImgFileURL = "https://example.com/images/car2.jpg", // Example URL for the image file
                    CarId = 2
                }
                // Add more seed data as needed
            );
        }
    }
}