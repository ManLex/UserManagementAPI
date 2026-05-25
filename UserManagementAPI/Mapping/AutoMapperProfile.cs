using AutoMapper;
using UserManagementAPI.DTOs;
using UserManagementAPI.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UserManagementAPI.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserResponseDto>();
            CreateMap<UserCreateDto, User>();
            CreateMap<UserUpdateDto, User>();
        }
    }
}
