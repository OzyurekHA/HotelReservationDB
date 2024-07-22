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
    public class RoomTypeService : IRoomTypeService
    {
        private readonly RoomTypeRepository _roomTypeRepository;

        public RoomTypeService(RoomTypeRepository roomTypeRepository)
        {
            _roomTypeRepository = roomTypeRepository;
        }

        public List<RoomType> GetAll()
        {
            return _roomTypeRepository.GetAll();
        }

        public RoomType GetById(string id)
        {
            return _roomTypeRepository.Get(r => r.Id.ToString() == id);
        }

        public void Insert(RoomType entity)
        {
            _roomTypeRepository.Add(entity);
        }

        public void Modify(RoomType entity)
        {
            _roomTypeRepository.Update(entity);
        }

        public void Remove(RoomType entity)
        {
            _roomTypeRepository.Delete(entity);
        }
    }
}
