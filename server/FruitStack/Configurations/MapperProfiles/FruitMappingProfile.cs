using AutoMapper;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Responses;

namespace FruitStack.Configurations.MapperProfiles
{
    public class FruitMappingProfile : Profile
    {

        public FruitMappingProfile()
        {
            CreateMap<FruityviceResponse, FruitResponse>().ForMember(member => member.ImageUrls, opt => opt.MapFrom<ImageResolver>());
        }

    }
    public class ImageResolver : IValueResolver<FruityviceResponse, FruitResponse, IEnumerable<string>>
    {
        private readonly IImageService _imageService;

        public ImageResolver(IImageService imageService)
        {
            _imageService = imageService;
        }

        public IEnumerable<string> Resolve(FruityviceResponse source, FruitResponse destination, IEnumerable<string> destMember, ResolutionContext context)
        {
            return Task.Run(async () => await _imageService.GetImageAsync(source.Name, 3)).Result;
        }
    }
}
