using Microsoft.EntityFrameworkCore;
using proje_data.Context;
using proje_data.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_data.Repository.Concrete
{
    public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : class
    {
        protected readonly AppDbContext Context;
        private DbSet<Entity> entities;

        public GenericRepository(AppDbContext dbContext)
        {
            this.Context = dbContext;
            this.entities = Context.Set<Entity>();
        }

        public Task<IEnumerable<Entity>> FindAsync(System.Linq.Expressions.Expression<Func<Entity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Entity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Entity> GetByIdAsync(int entityId)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveAsync(Entity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity entity)
        {
            throw new NotImplementedException();
        }
    }
}
