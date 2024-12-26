using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Data.Entities
{
    public class RoomEntity : BaseEntitiy
    {
        public int HotelId { get; set; }
        public string RoomNumber { get; set; }

        public ICollection<ReservationEntity> Reservations { get; set; }
        public HotelEntity Hotel { get; set; }
    }
}
