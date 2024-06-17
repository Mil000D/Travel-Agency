namespace MASProject.Shared.DTOs.TransportDTOs
{
	public class GetTransportDTO
	{
		public int Id { get; set; }
		public string Description { get; set; } = null!;
		public string Company { get; set; } = null!;
		public string Capacity { get; set; } = null!;
		public bool AirConditioning { get; set; }
		public float MaxSpeed { get; set; }
		public int CargoCapacity { get; set; }
		public string TransportType { get; set; } = null!;
	}
}
