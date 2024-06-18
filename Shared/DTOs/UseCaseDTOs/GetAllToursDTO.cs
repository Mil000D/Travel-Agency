using MASProject.Shared.DTOs.TourDTOs;

namespace MASProject.Shared.DTOs.UseCaseDTOs
{
    public class GetAllToursDTO
    {
        public List<GetTourDTO> Tours { get; set; } = null!;
        public int ToursCount { get; set; }
    }
}
