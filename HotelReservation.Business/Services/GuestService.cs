using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Business.Services
{
    public class GuestService : IGuestService
    {
        private readonly GuestRepository _guestRepo;
        public GuestService(GuestRepository guestRepository)
        {
            _guestRepo = guestRepository;
        }

        public List<Guest> GetAll()
        {
            return _guestRepo.GetAll(x => x.IsDeleted == false);
        }

        public Guest GetById(string id)
        {
            return _guestRepo.Get(g => g.Id.ToString() == id);
        }

        public bool IfEntityExists(string FirstName, string LastName)
        {
            return _guestRepo.IfEntityExists(g => g.FirstName == FirstName && g.LastName == LastName);
        }

        public void Insert(Guest entity)
        {
            _guestRepo.Add(entity);
        }

        public void Modify(Guest entity)
        {
            _guestRepo.Update(entity);
        }

        public void Remove(Guest entity)
        {
            _guestRepo.Delete(entity);
        }
    }
}
