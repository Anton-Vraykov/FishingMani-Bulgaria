using FishingManiаBulgaria.Common;
using System.ComponentModel.DataAnnotations;

namespace FishingManiаBulgaria.Data.Models
{
    public class Event
    {
        [Key]
        public Guid Id { get; set; }= Guid.NewGuid();
        [Required]
        [MaxLength(ValidationConstant.EventNameMax)]
        public string Name { get; set; }=string.Empty;
        [Required]
        public string ImageURL { get; set; }= string.Empty;
        public decimal Price { get; set; }
        public virtual ICollection<FishingPlace> FishingPlaces { get; set; } = new HashSet<FishingPlace>();
    }
}
