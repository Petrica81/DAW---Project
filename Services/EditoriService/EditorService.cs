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
            var editori = await _unitOfWork.ArticolRepository.GetAll();
            return _mapper.Map<List<Editor>>(editori);
        }

        public async Task Create(Editor newEditor)
        {
            await _unitOfWork.ArticolRepository.CreateAsync(newEditor);
            await _unitOfWork.ArticolRepository.SaveAsync();
        }
        public async Task<bool> Update(Guid id, EditorResponseDTO newEditor)
        {
            var editor = await _unitOfWork.ArticolRepository.FindByIdAsync(id);

            if(editor == null)
            {
                return false;
            }
            editor.Email = newEditor.Email;
            editor.Nume = newEditor.Nume;
            editor.Prenume = newEditor.Prenume;
            editor.Editura = newEditor.Editura;

            await _unitOfWork.SaveAsync();
            return true;

        }
        public async Task Delete(Guid id)
        {
            var editor = await _unitOfWork.ArticolRepository.FindByIdAsync(id);

            _unitOfWork.ArticolRepository.Delete(editor);
            await _unitOfWork.ArticolRepository.SaveAsync();
        }
    }
}
