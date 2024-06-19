using MASProject.Server.Comparers;
using MASProject.Server.Converters;
using MASProject.Server.Models.TourModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MASProject.Server.Configurations
{
    /// <summary>
    /// Configuration class for the Tour entity type.
    /// </summary>
    public class TourEntityTypeConfiguration : IEntityTypeConfiguration<Tour>
    {
        /// <summary>
        /// Configures the Tour entity.
        /// </summary>
        /// <param name="builder">The builder used to configure the Tour entity.</param>
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.Description)
                   .IsRequired()
                   .HasMaxLength(1000);

            builder.Property(t => t.Popularity)
                   .IsRequired(false)
                   .HasDefaultValue(0);

            builder.Property(t => t.ImagesURL)
                   .IsRequired()
                   .HasConversion(new ListOfStringsConverter(" "))
                   .Metadata.SetValueComparer(new ListOfStringsComparer());

            builder.HasData(
                new Tour
                {
                    Id = 1,
                    Title = "Lower Antelope Canyon",
                    Description = "Discover the lesser-traveled depths of Antelope Canyon on a walking tour through the lower portions of this colorful sandstone slot canyon.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/07/7f/67/da.jpg", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/90/31/4c/caption.jpg", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/8f/68/c5/caption.jpg", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/8f/68/ca/caption.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 2,
                    Title = "Niagara Falls",
                    Description = "Discover the highlights of several cities in the Northeast on this 4-day sightseeing tour by bus or minivan from Boston.",
                    ImagesURL = new List<string> { "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0d/46/b6/9c/20161010-133807-largejpg.jpg", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0c/7d/1f/18/photo3jpg.jpg", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/d4/be/31/view-from-one-of-the_rotated_90.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 3,
                    Title = "Grand Canyon",
                    Description = "Ideal for travelers short on time, this tour covers the Grand Canyon’s South Rim in one day of sightseeing from Las Vegas.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/33.jpg", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/9a/19/3e.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 4,
                    Title = "Horseshoe Bend",
                    Description = "Journey to Horseshoe Bend on a guided tour that includes all your entrance fees, round-trip transport from Flagstaff, and a picnic lunch.",
                    ImagesURL = new List<string> { "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/17/56/c1/06/horseshoe-bend-az.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 5,
                    Title = "Lake Powell",
                    Description = "This man-made reservoir, located in northern Arizona and southern Utah, is a great spot for travelers seeking nature and outdoor adventure.",
                    ImagesURL = new List<string> { "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/91/5b/02/morning-at-the-lake-powell.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 6,
                    Title = "Yellowstone Tour",
                    Description = "Avoid crowds and maximize your wildlife-viewing experience on this private Yellowstone tour led by a naturalist guide.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/10/8e/af/dd.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 7,
                    Title = "Yosemite Valley",
                    Description = "Immerse yourself in the majestic beauty of Yosemite National Park on this 2-day overnight adventure from San Francisco. Great way to spend holidays.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0b/2b/8a/7e.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 8,
                    Title = "The Narrows",
                    Description = "Explore the Incredible Narrows portion of Zion National Park without the risk of getting lost on this private full-day tour. A fun day out for travelers.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0f/2c/ff/9e.jpg" },
                    Popularity = 1
                },
                new Tour
                {
                    Id = 9,
                    Title = "Bryce Canyon",
                    Description = "Discover the stunning landscape of Bryce Canyon National Park on a full-day tour from Las Vegas that features a scenic round-trip journey by air.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/af/93/2e.jpg", "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/0a/af/93/36.jpg" },
                },
                new Tour
                {
                    Id = 10,
                    Title = "Monument Valley",
                    Description = "Explore Monument Valley Navajo Tribal Park on a full-day tour that features a visit to the Navajo Nation’s largest trading post.",
                    ImagesURL = new List<string> { "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/21/de/5b/97/caption.jpg", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/21/de/5b/c2/caption.jpg" },
                },
                new Tour
                {
                    Id = 11,
                    Title = "Arches National Park",
                    Description = "Discover the natural beauty of Arches National Park on this tour from Moab. A great way to spend a day out.",
                    ImagesURL = new List<string> { "https://media-cdn.tripadvisor.com/media/attractions-splice-spp-720x480/07/79/64/21.jpg" },
                },
                new Tour
                {
                    Id = 12,
                    Title = "Canyonlands National Park",
                    Description = "Discover the natural beauty of Canyonlands National Park on this tour from Moab. A great way to spend a day out.",
                    ImagesURL = new List<string> { "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/dc/dd/3d/mesa-arch-view.jpg" },
                }
            );
        }
    }
}
