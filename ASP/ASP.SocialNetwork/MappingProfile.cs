using ASP.SocialNetwork.Contracts;
using ASP.SocialNetwork.Models.DAL;
using AutoMapper;
using System;

namespace ASP.SocialNetwork
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<RegisterViewModel, User>()
                .ForMember(x => x.BirthDate, opt => opt.MapFrom(c => new DateTime((int)c.Year, (int)c.Month, (int)c.Date)))
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.EmailReg))
                .ForMember(x => x.UserName, opt => opt.MapFrom(c => c.Login));
            CreateMap<LoginViewModel, User>();
        }
    }
}
