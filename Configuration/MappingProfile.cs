using AutoMapper;
using RegistrationWizard.DTOs;
using RegistrationWizard.Models;

namespace RegistrationWizard.Configuration
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegistrationDto, ApplicationUser>()
                .ForMember(d => d.UserName, o => o.MapFrom(s => s.Email))
                .ForMember(d => d.IsAgreed, o => o.MapFrom(s => s.IsAgreed));
        }
    }
}
