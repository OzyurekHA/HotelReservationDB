using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        //Navigation Properties
        public ICollection<Booking> Bookings { get; set; }
    }
}
