using AutoMapper;
using Cer.WebApi.Application.Model;
using Cer.WebApi.Domain.Entity;

namespace Cer.WebApi.Cross.Mapper
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<User, UserModel>().ReverseMap();
        }
    }
}
