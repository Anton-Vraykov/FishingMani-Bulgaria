using System.ComponentModel.DataAnnotations.Schema;
using FishingManiаBulgaria.Common;
namespace FishingManiаBulgaria.Data.Models
{
    public class ApplicationUserFishingPlace
    {
        public Guid ApplicationUserId { get; set; }= Guid.NewGuid();
        [ForeignKey(nameof(ApplicationUserId))]
        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid FishingPlaceId { get; set; }
        [ForeignKey(nameof(FishingPlaceId))]
        public virtual FishingPlace Product { get; set; } = null!;
    }
}
