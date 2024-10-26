using FishingManiаBulgaria.Common;
using System.ComponentModel.DataAnnotations;

namespace FishingManiаBulgaria.Data.Models
{
    public class FishingPlace
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(ValidationConstant.PlaceNameMax)]
        public string Name { get; set; }=string.Empty;
        [Required]
        public string PictureURL { get; set; }= string.Empty;
        [Required]
        [MaxLength(ValidationConstant.PlaceLocationMax)]
        public string Location { get; set; }
        public DateTime Reservation { get; set; }
        [Required]
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsDeleted { get; set; }

    }
}
