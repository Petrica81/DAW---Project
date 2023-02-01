using AutoMapper;
using Ziare.Models;
using Ziare.Models.DTOs.ZiarDTOs;

namespace Ziare.Helpers.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Ziar, ZiarResultsDTO>().ReverseMap();
        }
    }
}
