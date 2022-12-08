using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ThyBilet.Entity;

namespace ThyBilet.Repositories
{
    public class Repository<T> where T : class, new()
    {
        ThyBiletEntities db = new ThyBiletEntities();

        public List<T> GetAll() //listeleme için oluşturdum
        {
            return db.Set<T>().ToList();
        }

        public List<T> GetListByID(Expression<Func<T,bool>> where) //şartlı listeleme için oluşturdum
        {
            return db.Set<T>().Where(where).ToList();
        }

        public void TAdd(T p) //veri ekleme için oluşturdum
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }

        public void TDelete(T p) //veri silmek için oluşturdum
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }

        public T TGet(int id) //id'ye göre bulma işlemini yapsın diye oluşturdum
        {
            return db.Set<T>().Find(id);
        }

        public void TUpdate(T p)//veri güncellemek için oluşturdum
        {
            db.SaveChanges();
        }

        public T Find(Expression<Func<T,bool>> filter)
        {
            return db.Set<T>().FirstOrDefault(filter);
        }
    }
}
