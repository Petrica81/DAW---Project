using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Models.Base;

namespace Ziare.Repositories.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly ZiarContext _context;
        protected readonly DbSet<TEntity> _table;

        public GenericRepository(ZiarContext context)
        {
            _context = context;
            _table = context.Set<TEntity>();
        }   

        //get all
        public async Task<List<TEntity>> GetAll()
        {
            return await _table.AsNoTracking().ToListAsync();
        }

        public async IAsyncEnumerable<TEntity> GetAllEnumerable() 
        {
            var vector = await _table.AsNoTracking().ToListAsync();
            foreach (var index in vector)
            {
                yield return index;
            }
        }

        //create
        public async Task CreateAsync(TEntity entity)
        {
            await _table.AddAsync(entity);
        }

        public async Task CreateRangeAsync(IEnumerable<TEntity> entities)
        {
            await _table.AddRangeAsync(entities);
        }

        //update
        public void Update(TEntity entity) 
        {
            _table.Update(entity);
        }
        public void UpdateRange(IEnumerable<TEntity> entities)
        {
            _table.UpdateRange(entities);
        }

        //delete
        public void Delete(TEntity entity)
        {
            _table.Remove(entity);
        }
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _table.RemoveRange(entities);
        }

        //Find
        public async Task<TEntity> FindByIdAsync(Guid id)
        {
            return await _table.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        //Save
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
