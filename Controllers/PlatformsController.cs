using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlatformService.Data;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Controllers;

/// <summary>
/// Platforms Controller.
/// </summary>
[Route("api/platforms")]
[ApiController]
public class PlatformsController : ControllerBase
{
    private readonly IPlatformRepo repository;
    private readonly IMapper mapper;

    /// <summary>
    /// <see cref="PlatformsController"/> constructor.
    /// </summary>
    /// <param name="repository">Platform Repository</param>
    /// <param name="mapper">Auto mapper</param>
    public PlatformsController(IPlatformRepo repository, IMapper mapper)
    {
        this.repository=repository;
        this.mapper=mapper;
    }

    /// <summary>
    /// Gets all platforms.
    /// </summary>
    /// <returns>IEnumerable of <see cref="PlatformReadDto"/></returns>
    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
    {
        var platformItens = repository.GetAllPlatforms();

        return Ok(mapper.Map<IEnumerable<PlatformReadDto>>(platformItens));
    }

    /// <summary>
    /// Gets a platform by id.
    /// </summary>
    /// <param name="id">Platform id.</param>
    /// <returns><see cref="PlatformReadDto"/></returns>
    [HttpGet("{id}", Name = "GetPlatformById")]
    public ActionResult<PlatformReadDto> GetPlatformById(int id)
    {
        var platform = repository.GetPlatformById(id);

        if (platform != null)
        {
            return Ok(mapper.Map<PlatformReadDto>(platform));
        }

        return NotFound();
    }

    /// <summary>
    /// Creates a new platform.
    /// </summary>
    /// <param name="platform">Platform to create</param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformDto)
    {
        var platform = mapper.Map<Platform>(platformDto);

        repository.CreatePlatform(platform);
        repository.SaveChanges();

        var platformReadDto = mapper.Map<PlatformReadDto>(platform);

        return CreatedAtRoute(nameof(GetPlatformById), new { Id = platformReadDto.Id }, platformReadDto);
    }
}
