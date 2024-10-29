using System.ComponentModel.DataAnnotations.Schema;
using FishingManiаBulgaria.Common;
using Microsoft.AspNetCore.Identity;
namespace FishingManiаBulgaria.Data.Models
{
    public class ApplicationUserFishingPlace
    {
        public string ApplicationUserId { get; set; }//= Guid.NewGuid();
        [ForeignKey(nameof(ApplicationUserId))]
        public virtual IdentityUser ApplicationUser { get; set; } = null!;

        public Guid FishingPlaceId { get; set; }
        [ForeignKey(nameof(FishingPlaceId))]
        public virtual FishingPlace Product { get; set; } = null!;
    }
}
