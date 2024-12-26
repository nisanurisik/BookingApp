using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Entities
{
    public class FeatureEntity : BaseEntitiy
    {
        public string Title { get; set; }
        public ICollection<HotelFeatureEntity> HotelFeatures { get; set; }
    }

}
