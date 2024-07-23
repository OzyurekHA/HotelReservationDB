using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess.Abstact
{
    public interface IRepository<T> where T : class //Buraya IEntity ve new() eklemedim, eklensin mi?
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        bool IfEntityExists(Expression<Func<T,bool>> filter);
    }
}
