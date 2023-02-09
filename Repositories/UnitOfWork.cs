using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Ziare.Data;
using Ziare.Repositories.ArticoleRepository;
using Ziare.Repositories.BiblioteciRepository;
using Ziare.Repositories.ClientiRepository;
using Ziare.Repositories.EditoriRepository;
using Ziare.Repositories.ZiareRepository;

namespace Ziare.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IZiareRepository ZiareRepository { get; set; }
        public IEditoriRepository EditoriRepository { get; set; }
        public IClientiRepository ClientiRepository { get; set; }
        public IArticoleRepository ArticoleRepository { get; set; }
        public IBiblioteciRepository BiblioteciRepository { get; set; }

        public ZiarContext _ziarContext { get; set; }

        public UnitOfWork(IZiareRepository ziareRepository, IEditoriRepository editoriRepository, IArticoleRepository articoleRepository, IBiblioteciRepository biblioteciRepository, IClientiRepository clientiRepository, ZiarContext ziarcontext)
        {
            ZiareRepository = ziareRepository;
            EditoriRepository = editoriRepository;
            ArticoleRepository = articoleRepository;
            BiblioteciRepository = biblioteciRepository;
            ClientiRepository = clientiRepository;
            _ziarContext = ziarcontext;
        }

        public async Task<bool> SaveAsync()
        {
            try
            {
                return await _ziarContext.SaveChangesAsync() > 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Eroare");
                Console.WriteLine(ex);
            }

            return false;
        }
    }
}
