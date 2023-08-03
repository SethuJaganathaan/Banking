using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Application.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<PersonalDetail, PersonDTO>().ReverseMap();
        }
    }
}