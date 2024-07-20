using HotelReservation.Entity.Abstract;

namespace HotelReservation.Entity.Concrete
{
    public class RoomType : BaseEntity
    {
        public string TypeName { get; set; }
        public string Description { get; set; }
        public decimal PricePerNight { get; set; }
        public int Capacity { get; set; }
        
        //Navigation Property
        public ICollection<Room> Room { get; set; }
    }
}
