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
    public class RoomService : IRoomService
    {
        private readonly RoomRepository _roomRepo;

        public RoomService(RoomRepository roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public List<Room> GetAll()
        {
            return _roomRepo.GetAll();
        }

        public Room GetById(string id)
        {
            return _roomRepo.Get(r => r.Id.ToString() == id);
        }

        public bool IfEntityExists(int RoomNumber)
        {
            return _roomRepo.IfEntityExists(g => g.RoomNumber == RoomNumber);
        }

        public void Insert(Room entity)
        {
            _roomRepo.Add(entity);
        }

        public void Modify(Room entity)
        {
            _roomRepo.Update(entity);
        }

        public void Remove(Room entity)
        {
            _roomRepo.Delete(entity);
        }
    }
}
