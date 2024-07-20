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

    public class Staff : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string StaffPhoneNumber { get; set; }
        public string StaffEmail { get; set; }
        public DateOnly HireDate { get; set; }
        
        //Navigation Property
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }

    public class Room : BaseEntity
    {
        public bool IsReserved { get; set; }
        
        //Navigation Properties
        public Guid HotelId { get; set; }
        public Hotel Hotel { get; set; }

        public Guid RoomTypeId { get; set; }
        public RoomType RoomType { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }

    public class RoomType : BaseEntity
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public int Capacity { get; set; }
        
        //Navigation Property
        public ICollection<Room> Room { get; set; }
    }

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

    public class BookingGuests : BaseEntity
    {
        public Guid BookingId { get; set; }
        public Booking Booking { get; set; }
        public Guid GuestId { get; set; }
        public Guest Guest { get; set; }

    }

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

    public class Payment : BaseEntity
    {
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentMethod { get; set; }

        //Navigation Properties
        public ICollection<Booking> Bookings { get; set; }
    }
}
