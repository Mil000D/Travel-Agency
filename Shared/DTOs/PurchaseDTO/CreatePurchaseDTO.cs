using MASProject.Shared.DTOs.PaymentMethodDTOs;
namespace MASProject.Shared.DTOs.PurchaseDTOs
{
    public class CreatePurchaseDTO
    {
        public int Id { get; set; }
        public float TotalPrice { get; set; }
        public GetPaymentMethodDTO PaymentMethod { get; set; } = null!;
        public DateTime PaymentDate { get; set; }
    }
}
