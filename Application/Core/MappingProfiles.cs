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
            CreateMap<UserSecurityQuestion, UserSecurityQuestionDTO>().ReverseMap();

            CreateMap<QuestionAnswerDTO, UserSecurityQuestion>()
                .ForMember(dest => dest.UserQuestionId, opt => opt.Ignore()) 
                //.ForMember(dest => dest.UserId, opt =)
                .ForMember(dest => dest.QuestionId, opt => opt.MapFrom(src => src.QuestionId))
                .ForMember(dest => dest.Answer, opt => opt.MapFrom(src => src.Answer));
        }
    }
}