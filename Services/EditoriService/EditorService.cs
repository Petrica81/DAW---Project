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
        public async Task<bool> Update(Guid id, EditorResponseDTO newEditor)
        {
            var editor = await _unitOfWork.EditoriRepository.FindByIdAsync(id);

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
            var editor = await _unitOfWork.EditoriRepository.FindByIdAsync(id);

            _unitOfWork.EditoriRepository.Delete(editor);
            await _unitOfWork.EditoriRepository.SaveAsync();
        }

        public List<NumarEditoriDTO> CountEditori()
        {
            return _unitOfWork.EditoriRepository.CountEditori();
        }
    }
}
