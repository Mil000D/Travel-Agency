namespace MASProject.Shared.DTOs.TourDTOs
{
    public class GetBookedTourDetailsDTO
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Price { get; set; }
        public string PaymentMethod { get; set; } = null!;
        public DateTime? PaymentDate { get; set; }
    }
}

