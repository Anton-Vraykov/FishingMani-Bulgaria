using FishingManiаBulgaria.Common;

namespace FishingManiаBulgaria.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    public class ApplicationUser: IdentityUser<Guid>
    {
        public ApplicationUser() 
        {
            
            this.Id = Guid.NewGuid();
        }

        public virtual ICollection<ApplicationUserFishingPlace> ApplicationUserProduct { get; set; }
            = new HashSet<ApplicationUserFishingPlace>();

    }
}
