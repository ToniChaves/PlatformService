using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles;

/// <summary>
/// PlatformProfile class.
/// </summary>
public class PlatformProfile : Profile
{
    /// <summary>
    /// PlatformProfile constructor.
    /// </summary>
    public PlatformProfile() 
    {
        // Source -> Target
        CreateMap<Platform, PlatformReadDto>();

        //Target -> Source
        CreateMap<PlatformCreateDto, Platform>();
    }
}
