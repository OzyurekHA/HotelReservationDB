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
    public class HotelService : IHotelService
    {
        private readonly HotelRepository _hotelRepo;
        public HotelService(HotelRepository hotelRepo)
        {
            _hotelRepo = hotelRepo;
        }

        public List<Hotel> GetAll()
        {
            return _hotelRepo.GetAll();
        }

        public Hotel GetById(string id)
        {
            return _hotelRepo.Get(h => h.Id.ToString() == id);
        }

        public void Insert(Hotel entity)
        {
            _hotelRepo.Add(entity);
        }

        public void Modify(Hotel entity)
        {
            _hotelRepo.Update(entity);
        }

        public void Remove(Hotel entity)
        {
            _hotelRepo.Delete(entity);
        }
    }
}
