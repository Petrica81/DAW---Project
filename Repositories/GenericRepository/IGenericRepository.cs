using Ziare.Models.Base;

namespace Ziare.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        //get all
        Task<List<TEntity>> GetAll();

        IAsyncEnumerable<TEntity> GetAllEnumerable();

        //create
        Task CreateAsync(TEntity entity);
        Task CreateRangeAsync(IEnumerable<TEntity> entities);

        //update
        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);

        //delete
        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        //Find
        Task<TEntity> FindByIdAsync(Guid Id);

        //Save
        Task<bool> SaveAsync();

    }
}
