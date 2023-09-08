using AutoMapper;
using StewardAPI.Dto;
using Model;
using StewardAPI.Models;

namespace StewardAPI.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ApplicationUser, RegistrationDTO>().ReverseMap();
            CreateMap<Doctor,DoctorDTO>().ReverseMap();
        }
    }
}
