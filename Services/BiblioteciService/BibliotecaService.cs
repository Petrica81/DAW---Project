using AutoMapper;
using Ziare.Models;
using Ziare.Repositories;

namespace Ziare.Services.BiblioteciService
{
    public class BibliotecaService : IBibliotecaService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public BibliotecaService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<Biblioteca>> GetAll()
        {
            var Bibliotecai = await _unitOfWork.BiblioteciRepository.GetAll();
            return _mapper.Map<List<Biblioteca>>(Bibliotecai);
        }

        public async Task Create(Biblioteca newBiblioteca)
        {
            await _unitOfWork.BiblioteciRepository.CreateAsync(newBiblioteca);
            await _unitOfWork.BiblioteciRepository.SaveAsync();
        }

        public async Task Delete(Guid id)
        {
            var Biblioteca = await _unitOfWork.BiblioteciRepository.FindByIdAsync(id);

            _unitOfWork.BiblioteciRepository.Delete(Biblioteca);
            await _unitOfWork.BiblioteciRepository.SaveAsync();
        }
    }
}
