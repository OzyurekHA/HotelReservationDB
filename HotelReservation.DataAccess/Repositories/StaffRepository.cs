using HotelReservation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess.Repositories
{
    public class StaffRepository : GenericRepository<Staff>
    {
        public StaffRepository(ApplicationDBContext context) : base(context)
        {
        }
    }
}
