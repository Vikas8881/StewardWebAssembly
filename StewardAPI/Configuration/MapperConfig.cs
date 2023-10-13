using AutoMapper;

using Model;
using StewardAPI.Models;
using Model.DTO;

namespace StewardAPI.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<ApplicationUser, RegistrationDTO>().ReverseMap();

            CreateMap<Doctor, DoctorDTO>().ReverseMap();

            CreateMap<PatientCreateDTO, Patient>().ReverseMap();
            CreateMap<PatientComplainDTO, pComplain>().ReverseMap();


            //Complaints DTO
            CreateMap<PatientInvestigationDTO, pInvestigation>().ReverseMap();

        }
    }
}
