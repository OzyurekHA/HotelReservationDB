using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class Guest : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        //Navigation Property
        public ICollection<BookingGuests> BookingGuests { get; set; }
    }
}
