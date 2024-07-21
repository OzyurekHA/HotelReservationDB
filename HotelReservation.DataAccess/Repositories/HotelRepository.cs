using HotelReservation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess.Repositories
{
    public class HotelRepository : GenericRepository<Hotel>
    {
        public HotelRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
