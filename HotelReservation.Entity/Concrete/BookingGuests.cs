using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class BookingGuests : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }
        public Guid GuestId { get; set; }
        public Guest Guest { get; set; }

    }
}
