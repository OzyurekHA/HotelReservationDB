﻿using HotelReservation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Business.Abstract
{
    public interface IGuestService : IManager<Guest>
    {
        bool IfEntityExists(string FirstName, string LastName);
    }
}
