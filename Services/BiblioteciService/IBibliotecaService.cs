using Ziare.Models;

namespace Ziare.Services.BiblioteciService
{
    public interface IBibliotecaService
    {
        Task<List<Biblioteca>> GetAll();
        Task Create(Biblioteca newBiblioteca);
        Task Delete(Guid id);
    }
}
