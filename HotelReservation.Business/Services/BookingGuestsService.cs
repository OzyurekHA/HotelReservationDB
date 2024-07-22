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
    public class BookingGuestsService : IBookingGuestsService
    {
        private readonly BookingGuestsRepository _repo;
        public BookingGuestsService(BookingGuestsRepository bookingGuestsRepository)
        {
            _repo = bookingGuestsRepository;
        }
        public List<BookingGuests> GetAll()
        {
            return _repo.GetAll();
        }

        public BookingGuests GetById(string id)
        {
            return _repo.Get(b => b.Id.ToString(id) == id);
        }

        public void Insert(BookingGuests entity)
        {
            _repo.Add(entity);
        }

        public void Modify(BookingGuests entity)
        {
            _repo.Update(entity);
        }

        public void Remove(BookingGuests entity)
        {
            _repo.Delete(entity);
        }
    }
}
