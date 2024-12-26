using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Entities
{
    public class HotelFeatureEntity : BaseEntitiy
    {
        public int OtelId { get; set; }
        public int FeatureId { get; set; }

        public HotelEntity Hotel { get; set; }
        public FeatureEntity Feature { get; set; }
    }
}
