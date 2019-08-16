using AutoMapper;
using Cer.WebApi.Application.Model;
using Cer.WebApi.Domain.Entity;

namespace Cer.WebApi.Cross.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            // CreateMap<User, UserModel>().ReverseMap();

            CreateMap<User, UserModel>().ReverseMap();
            CreateMap<User, UserAddModel>().ReverseMap();
            CreateMap<Rol, RolModel>().ReverseMap();
            CreateMap<UserProfile, UserProfileModel>().ReverseMap();
        }
    }
}
