using MASProject.Server.Models.TourModels;
using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.UserModels
{
    public class Customer : User
    {
        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength = 5)]
        public string Email { get; set; } = null!;
        [Required]
        [StringLength(20, MinimumLength = 7)]
        public string PhoneNumber { get; set; } = null!;
        public ICollection<TourPurchase>? TourPurchases { get; set; }
    }
}
