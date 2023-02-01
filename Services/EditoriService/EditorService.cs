using AutoMapper;
using Ziare.Models;
using Ziare.Models.DTOs.EditorDTOs;
using Ziare.Repositories;

namespace Ziare.Services.EditoriService
{
    public class EditorService : IEditorService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public EditorService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public EditorRequestDTO GetById(Guid id)
        {
            //!!! trebuie sa implementez, nu UITA!
            return new EditorRequestDTO { };
        }
        public async Task<List<Editor>> GetAll()
        {
            var editori = await _unitOfWork.EditoriRepository.GetAll();
            return _mapper.Map<List<Editor>>(editori);
        }

        public async Task Create(Editor newEditor)
        {
            await _unitOfWork.EditoriRepository.CreateAsync(newEditor);
            await _unitOfWork.EditoriRepository.SaveAsync();
        }

        public async Task Delete(Guid id)
        {
            var editor = await _unitOfWork.EditoriRepository.FindByIdAsync(id);

            _unitOfWork.EditoriRepository.Delete(editor);
            await _unitOfWork.EditoriRepository.SaveAsync();
        }
    }
}
