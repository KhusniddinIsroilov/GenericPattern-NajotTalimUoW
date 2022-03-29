using Microsoft.EntityFrameworkCore;
using NajotTalimUoW.Data.Contexts;
using NajotTalimUoW.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NajotTalimUoW.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
#pragma warning disable

        internal NajotTalimDbContext najotTalimDbContext;
        private DbSet<T> dbSet;

        public GenericRepository(NajotTalimDbContext najotTalimDbContext)
        {
            this.najotTalimDbContext = najotTalimDbContext;

            dbSet = this.najotTalimDbContext.Set<T>();
        }
        public async Task<T> CreateAsync(T entity)
        {
            var entry = await dbSet.AddAsync(entity);

            await najotTalimDbContext.SaveChangesAsync();

            return entry.Entity;

        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> expression)
        {
          var result = await dbSet.FirstOrDefaultAsync(expression);
            if (result == null)
                return false;

            dbSet.Remove(result);

          await  najotTalimDbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> expression = null)
        {
           return expression == null ? dbSet : dbSet.Where(expression);
        }

        public Task<T> GetAsync(Expression<Func<T, bool>> expression)
        {
           return  dbSet.FirstOrDefaultAsync(expression);
        }

        public async Task<T> UpdateAsync(T entity)
        {

          var entry =  dbSet.Update(entity);

          await  najotTalimDbContext.SaveChangesAsync();
            
          return entry.Entity;

        }
    }
}
