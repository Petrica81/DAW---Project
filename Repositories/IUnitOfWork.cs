using Ziare.Data;
using Ziare.Repositories.ArticoleRepository;
using Ziare.Repositories.BiblioteciRepository;
using Ziare.Repositories.ClientiRepository;
using Ziare.Repositories.EditoriRepository;
using Ziare.Repositories.ZiareRepository;

namespace Ziare.Repositories
{
    public interface IUnitOfWork
    {
        IZiareRepository ZiareRepository { get; }
        IEditoriRepository EditoriRepository { get; }
        IClientiRepository ClientiRepository { get; }
        IArticoleRepository ArticoleRepository { get; }
        IBiblioteciRepository BiblioteciRepository { get; }
        
        ZiarContext _ziarContext { get; }
        Task<bool> SaveAsync();
    }
}
