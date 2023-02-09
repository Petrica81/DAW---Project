using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;
using Ziare.Repositories.GenericRepository;

namespace Ziare.Repositories.ZiareRepository
{
    public class ZiareRepository : GenericRepository<Ziar>, IZiareRepository
    {
        public ZiareRepository(ZiarContext context) : base(context) { }

        public async Task<Ziar> GetById(Guid id)
        {
           return  await _table.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }
    }
}
