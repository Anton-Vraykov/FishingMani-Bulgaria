namespace FishingManiаBulgaria.Data.Models
{
    public class ApplicationUserFishingPlace
    {
        public Guid ApplicationUserId { get; set; }= Guid.NewGuid();

        public virtual ApplicationUser ApplicationUser { get; set; } = null!;

        public Guid FishingPlaceId { get; set; }

        public virtual FishingPlace Product { get; set; } = null!;
    }
}
