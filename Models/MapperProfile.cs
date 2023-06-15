using AutoMapper;
using EShop.Models;
using EShop.Models.DTOs;

namespace EShop.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile() 
        {
            CreateMap<User, UserAuthRequestDto>();
            CreateMap<UserAuthRequestDto, User>();
            CreateMap<UserAuthResponseDto, User>();
            CreateMap<User, UserAuthResponseDto>();
        }
    }
}
