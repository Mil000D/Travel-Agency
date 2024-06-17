using MASProject.Shared.DTOs.LodgingDTOs;
using MASProject.Shared.DTOs.TransportDTOs;

namespace MASProject.Shared.DTOs.TourDTOs
{
    public class GetTourDetailsDTO
    {
		public int Id { get; set; }
		public string Title { get; set; } = null!;
		public List<string> ImagesURL { get; set; } = null!;
		public string Description { get; set; } = null!;
		public int Popularity { get; set; }
		public int TotalPrice { get; set; }
		public List<GetLodgingDTO>? Lodgings { get; set; }
		public List<GetTransportDTO>? Transports { get; set; }
	}
}
