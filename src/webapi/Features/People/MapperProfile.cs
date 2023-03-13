using AutoMapper;
using webapi.Features.People.Queries;
using Domain;

namespace webapi.Features.People;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Person, GetPersonById.PersonByIdResult>();
    }
}
