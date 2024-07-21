using HotelReservation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess.Repositories
{
    public class RoomRepository : GenericRepository<Room>
    {
        public RoomRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
