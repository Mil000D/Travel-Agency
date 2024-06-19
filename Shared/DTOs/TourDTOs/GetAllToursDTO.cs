namespace MASProject.Shared.DTOs.TourDTOs
{
    public class GetAllToursDTO
    {
        public List<GetTourDTO> Tours { get; set; } = null!;
        public int ToursCount { get; set; }
    }
}
