using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using Ziare.Models;
using Ziare.Models.DTOs.ZiarDTOs;
using Ziare.Repositories;
using Ziare.Services.ZiareService;

namespace Ziare.Services.ZiarService
{
    public class ZiarService : IZiarService
    {
        public IUnitOfWork _unitOfWork;
        public IMapper _mapper;

        public ZiarService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork= unitOfWork;
            _mapper = mapper;
        }   
        public async Task<List<Ziar>> GetAll()
        {
            var ziare = await _unitOfWork.ZiareRepository.GetAll();
            return _mapper.Map<List<Ziar>>(ziare);
  
        }
        public IAsyncEnumerable<Ziar> GetAllEnumerable()
        {
            return _unitOfWork.ZiareRepository.GetAllEnumerable();
        }

        public async Task<List<ZiarResultsDTO>> GetAllDTO()
        {
            var ziare = await _unitOfWork.ZiareRepository.GetAll();
            return _mapper.Map<List<ZiarResultsDTO>>(ziare);

        }

        public async Task<Ziar> GetById(Guid id)
        {
            return await _unitOfWork.ZiareRepository.GetById(id);
        }

        public async Task<bool> TestareZiarId(Guid id)
        {
            var ziar = await _unitOfWork.ZiareRepository.FindByIdAsync(id);
            if (ziar == null)
            {
                return false;
            }
            return true;
        }
        public async Task Create(Ziar newZiar)
        {
            await _unitOfWork.ZiareRepository.CreateAsync(newZiar);
            await _unitOfWork.ZiareRepository.SaveAsync();
        }

        public async Task<bool> Update(Guid id, ZiarResultsDTO ziar)
        {
            var ziar2 = await _unitOfWork.ZiareRepository.FindByIdAsync(id);
            if (ziar2 == null)
            {
                return false;
            }
            ziar2.Titlu = ziar.Titlu;
            ziar2.Editura = ziar.Editura;
            ziar2.Domeniu = ziar.Domeniu;
            ziar2.Pret = ziar.Pret;

            await _unitOfWork.ZiareRepository.SaveAsync();
            return true;
        }

        public async Task Delete(Guid id)
        {
            var ziar = await _unitOfWork.ZiareRepository.FindByIdAsync(id);

            _unitOfWork.ZiareRepository.Delete(ziar);
            await _unitOfWork.ZiareRepository.SaveAsync();

        }
    }
}
