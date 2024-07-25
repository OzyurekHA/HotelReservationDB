using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class Staff : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
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
}
