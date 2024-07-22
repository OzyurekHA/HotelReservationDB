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
    public class StaffService : IStaffService
    {
        private readonly StaffRepository _staffRepository;

        public StaffService(StaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public List<Staff> GetAll()
        {
            return _staffRepository.GetAll();
        }

        public Staff GetById(string id)
        {
            return _staffRepository.Get(r => r.Id.ToString() == id);
        }

        public void Insert(Staff entity)
        {
            _staffRepository.Add(entity);
        }

        public void Modify(Staff entity)
        {
            _staffRepository.Update(entity);
        }

        public void Remove(Staff entity)
        {
            _staffRepository.Delete(entity);
        }
    }
}
