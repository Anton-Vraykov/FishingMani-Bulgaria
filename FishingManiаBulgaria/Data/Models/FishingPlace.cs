using FishingManiаBulgaria.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public Guid CarId { get; set; }
        [ForeignKey(nameof(CarId))]
        public Car Cars { get; set; } = null!;
        public Guid TypeFishingId { get; set; }
        [ForeignKey(nameof(TypeFishingId))]
        public TypesFishing TypesFishing { get; set; }=null!;
        public Guid EventId { get; set; }
        [ForeignKey(nameof(EventId))]
        public Event Events { get; set; }= null!;
        public bool IsDeleted { get; set; }
        public virtual ICollection<ApplicationUserFishingPlace> ApplicationUserProduct { get; set; }
            = new HashSet<ApplicationUserFishingPlace>();

    }
}
