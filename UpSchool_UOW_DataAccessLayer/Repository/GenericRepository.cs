using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UOW_DataAccessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Concrete;

namespace UpSchool_UOW_DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        //context.savechanges'leri async ve sync olarak yazabilmek için
        //burada değil ayrı bir sınıfta yazıp burada çağırarak yazarım.
        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);//updaterange metodu ile
                                    //Listeden gelen tüm elemanları günceller
            //Unit of work kullanımı ile 
        }

        public void Update(T t)
        {
            _context.Update(t);
        }
    }
}
