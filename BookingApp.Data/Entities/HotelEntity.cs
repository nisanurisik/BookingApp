using BookingApp.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Entities
{
    public class HotelEntity : BaseEntitiy
    {
        public string Name { get; set; }
        public int Stars { get; set; }
        public string Location { get; set; }
        public AccomodationType AccomodationType { get; set; }

        public ICollection<HotelFeatureEntity> HotelFeatures { get; set; }
        public ICollection<RoomEntity> Rooms { get; set; }
    }
}
