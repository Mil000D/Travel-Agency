using System.ComponentModel.DataAnnotations;

namespace MASProject.Server.Models.TransportModels
{
    public class Train : Transport
    {
        [Required]
        [StringLength(50, MinimumLength = 1)]
        public string TrainNumber { get; set; } = null!;
        [Required]
        [Range(1,4)]
        public int Classes { get; set; }
        public override string ToString()
        {
            return $"{Company} (Train - {TrainNumber})";
        }
    }
}
