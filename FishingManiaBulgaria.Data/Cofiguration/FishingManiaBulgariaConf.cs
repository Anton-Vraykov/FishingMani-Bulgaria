using FishingManiаBulgaria.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingManiaBulgaria.Data.Cofiguration
{
    public class FishingMAniaBulgariaConf : IEntityTypeConfiguration<ApplicationUserFishingPlace>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserFishingPlace> builder)
        {
            builder.HasKey(aufp=>new {aufp.ApplicationUserId,aufp.FishingPlaceId});
        }
    }
}
