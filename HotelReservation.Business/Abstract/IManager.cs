using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Business.Abstract
{
    public interface IManager<T> where T : class
    {
        void Insert(T entity);
        void Modify(T entity);
        void Remove(T entity);
        List<T> GetAll();
        T GetById(string id);
    }
}
