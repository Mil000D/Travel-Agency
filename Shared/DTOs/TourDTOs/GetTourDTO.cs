namespace MASProject.Shared.DTOs.TourDTOs
{
    public class GetTourDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string HeaderPhotoURL { get; set; } = null!;
    }
}
