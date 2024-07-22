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
    public class PaymentService : IPaymentService
    {
        private readonly PaymentRepository _paymentRepo;

        public PaymentService(PaymentRepository paymentRepo)
        {
            _paymentRepo = paymentRepo;
        }

        public List<Payment> GetAll()
        {
            return _paymentRepo.GetAll();
        }

        public Payment GetById(string id)
        {
            return _paymentRepo.Get(p => p.Id.ToString() == id);
        }

        public void Insert(Payment entity)
        {
            _paymentRepo.Add(entity);
        }

        public void Modify(Payment entity)
        {
            _paymentRepo.Update(entity);
        }

        public void Remove(Payment entity)
        {
            _paymentRepo.Delete(entity);
        }
    }
}
