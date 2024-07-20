using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class Booking : BaseEntity
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public decimal TotalPrice { get; set; }

        //Navigation Properties
        public Room Room { get; set; }

        public ICollection<BookingGuests> BookingGuests { get; set; }
        
        public Guid PaymentId { get; set; }
        public Payment Payment { get; set; }
    }
}
