
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FishingManiаBulgaria.Data.Models;

namespace FishingManiaBulgaria.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                 : base(options)
        {
        }
        public virtual DbSet<ApplicationUserFishingPlace> ApplicationUsersFishingPlaces { get; set; } = null!;

        public virtual DbSet<Car> Cars { get; set; } = null!;

        public virtual DbSet<Event> Events { get; set; } = null!;

        public virtual DbSet<FishingPlace> FishingPlaces { get; set; } = null!;
        public virtual DbSet<TypesFishing> TypesFishings { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
