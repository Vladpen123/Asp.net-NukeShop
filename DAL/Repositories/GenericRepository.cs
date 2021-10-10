using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public abstract class GenericRepository<T> : IRepositoryBase<T> where T : class
    {
        public ShopContext context;
        internal DbSet<T> set;

        protected GenericRepository(ShopContext context)
        {
            this.context = context;
            set = context.Set<T>();
        }

        public virtual Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> Get(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
