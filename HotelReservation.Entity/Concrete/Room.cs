using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class Room : BaseEntity
    {
        public int RoomNumber { get; set; }
        public bool IsReserved { get; set; }
        
        //Navigation Properties
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
