using FishingManiаBulgaria.Common;
using System.ComponentModel.DataAnnotations;

namespace FishingManiаBulgaria.Data.Models
{
    public class FishingPlace
    {
       
        [Key]
        public Guid Id { get; set; }=Guid.NewGuid();
        [Required]
        [MaxLength(ValidationConstant.PlaceNameMax)]
        public string Name { get; set; }=string.Empty;
        [Required]
        public string PictureURL { get; set; }= string.Empty;
        [Required]
        [MaxLength(ValidationConstant.PlaceLocationMax)]
        public string Location { get; set; } = string.Empty;
        public DateTime Reservation { get; set; }
        [Required]
        [MaxLength(ValidationConstant.PlaceDescriptionMax)]
        public string Description { get; set; }=string.Empty ;
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }

    }
}
