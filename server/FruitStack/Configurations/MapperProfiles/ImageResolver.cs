using AutoMapper;
using FruitStack.Infrastructure.Interfaces;
using FruitStack.Models.Constans;
using FruitStack.Models.Responses;

public class ImageResolver : IValueResolver<FruityviceResponse, FruitResponse, IEnumerable<string>>
{
    private readonly IImageService _imageService;

    public ImageResolver(IImageService imageService)
    {
        _imageService = imageService;
    }

    public IEnumerable<string> Resolve(FruityviceResponse source, FruitResponse destination, IEnumerable<string> destMember, ResolutionContext context)
    {
        var images = _imageService.GetImageAsync(source.Name, UnsplashConstans.ImageCount).Result;
        return images;
    }

}