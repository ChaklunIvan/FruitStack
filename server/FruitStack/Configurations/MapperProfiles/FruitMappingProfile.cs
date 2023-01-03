using AutoMapper;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models;
using FruitStack.Models.Responses;
using System.Reflection;

namespace FruitStack.Configurations.MapperProfiles
{
    public class FruitMappingProfile : Profile
    {
        public FruitMappingProfile()
        {
            CreateMap<FruityviceResponse, FruitResponse>().ForMember(member => member.ImageUrls, opt => opt.MapFrom<ImageResolver>());
        }
    }
}
