using HotelReservation.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Entity.Concrete
{
    public class Hotel : BaseEntity
    {
        public string HotelName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int Stars { get; set; }
        public DateTime CheckInTime { get; set; }
        public DateTime CheckOutTime { get; set; }
        
        //Navigation Properties
        public ICollection<Staff> HotelStaff { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
