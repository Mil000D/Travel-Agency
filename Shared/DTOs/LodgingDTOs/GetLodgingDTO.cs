namespace MASProject.Shared.DTOs.LodgingDTOs
{
    public class GetLodgingDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Owner { get; set; }
        public int? Stars { get; set; }
        public string? OfficialWebsiteURL { get; set; }
        public List<string>? Amenities { get; set; }
        public bool? PetFriendly { get; set; }
        public bool? BreakfastIncluded { get; set; }
        public string LodgingType { get; set; } = null!;
    }
}
