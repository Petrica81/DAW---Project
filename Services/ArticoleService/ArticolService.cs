using AutoMapper;
using Ziare.Models;
using Ziare.Models.DTOs.ArticolDTOs;
using Ziare.Repositories;

namespace Ziare.Services.ArticoleService
{
    public class ArticolService : IArticolService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public ArticolService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<Articol>> GetAll()
        {
            var articole = await _unitOfWork.ArticoleRepository.GetAll();
            return _mapper.Map<List<Articol>>(articole);
        }

        public async Task Create(Articol newArticol)
        {
            await _unitOfWork.ArticoleRepository.CreateAsync(newArticol);
            await _unitOfWork.SaveAsync();
        }
        public async Task<bool> Update(Guid id, ArticolResponseDTO newArticol)
        {
            var articol = await _unitOfWork.ArticoleRepository.FindByIdAsync(id);
            if(articol == null)
            {
                return false;
            }
            articol.Titlu = newArticol.Titlu;
            articol.Autor = newArticol.Autor;
            articol.Text = newArticol.Text;

            _unitOfWork.SaveAsync();
            return true;
        }
        public async Task Delete(Guid id)
        {
            var articol = await _unitOfWork.ArticoleRepository.FindByIdAsync(id);

            _unitOfWork.ArticoleRepository.Delete(articol);
            await _unitOfWork.ArticoleRepository.SaveAsync();
        }
    }
}
