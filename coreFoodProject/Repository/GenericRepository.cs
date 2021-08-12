using coreFoodProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace coreFoodProject.Repository
{
    public class GenericRepository<T> where T:class,new()
    {
        Context conte = new Context();
        public List<T> TList()
        {
            return conte.Set<T>().ToList();
        }
        public void TAdd(T p)
        {
            conte.Set<T>().Add(p);
            conte.SaveChanges();
        }
        public void TDelete(T p)
        {
            conte.Set<T>().Remove(p);
            conte.SaveChanges();
        }
        public void TUpdate(T p)
        {
            conte.Set<T>().Update(p);
            conte.SaveChanges();
        }
        public T TGet(int id)
        {
           return conte.Set<T>().Find(id);
        }

        //Food Controller/index içerisinde controller name'ini çekebilmek için 
        public List<T> TList(string p)
        {
            return conte.Set<T>().Include(p).ToList();
        }

        public List<T> List(Expression<Func<T,bool>> filter)
        {
            return conte.Set<T>().Where(filter).ToList();
        } 
    }
}
