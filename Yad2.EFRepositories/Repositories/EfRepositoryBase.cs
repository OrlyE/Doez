using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Domain;

namespace Yad2.EFRepositories.Repositories
{
    public class EfRepositoryBase<T> : IRepository<T,int> where T : EntityBase<int>
    {

        public void Add(T entity)
        {
            EFContext.Get().Set<T>().Add(entity);
            EFContext.Get().SaveChanges();
        }

        public void Remove(T entity)
        {
            EFContext.Get().Set<T>().Remove(entity);
            EFContext.Get().SaveChanges();
        }

        public virtual void Update(T entity)
        {
            T existing = EFContext.Get().Set<T>().Find(entity.Id);
            if (existing != null)
            {
                EFContext.Get().Entry(existing).CurrentValues.SetValues(entity);
                EFContext.Get().SaveChanges();
            }
        }

        public IEnumerable<T> FindAll()
        {
            return EFContext.Get().Set<T>().ToArray();
        }

        public T FindBy(int Id)
        {
            return EFContext.Get().Set<T>().FirstOrDefault(e => e.Id == Id);
        }
    }
}
