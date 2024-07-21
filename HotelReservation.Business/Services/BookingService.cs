using HotelReservation.Business.Abstract;
using HotelReservation.DataAccess;
using HotelReservation.DataAccess.Repositories;
using HotelReservation.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Business.Services
{
    public class BookingService : IManager<Booking>
    {
        private readonly BookingRepository _bookingRepository;

        public BookingService(BookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        public List<Booking> GetAll()
        {
            return _bookingRepository.GetAll();
        }

        public Booking GetById(string id)
        {
            return _bookingRepository.Get(b => b.Id.ToString() == id);
        }

        public void Insert(Booking entity)
        {
            _bookingRepository.Add(entity);
        }

        public void Modify(Booking entity)
        {
            _bookingRepository.Update(entity);
        }

        public void Remove(Booking entity)
        {
            _bookingRepository.Delete(entity);
        }
    }
}
