using AutoMapper;
using MediatR;
using webapi.Features.People.Exceptions;
using webapi.ServiceManager;

namespace webapi.Features.People.Queries;

public class GetPersonById
{
  //Input
  public class GetPersonByIdQuery : IRequest<PersonByIdResult>
  {
    public int Id { get; set; }
  }

  //Output
  public class PersonByIdResult
  {
    public int Id { get; set; }
    public string Name { get; set; }
  }

  //Handle
  public class Handler : IRequestHandler<GetPersonByIdQuery, PersonByIdResult>
  {
    private readonly IServiceManager _serviceManager;
    private readonly IMapper _mapper;

    public Handler(IServiceManager serviceManager, IMapper mapper)
    {
      _serviceManager = serviceManager;
      _mapper = mapper;
    }

    public async Task<PersonByIdResult> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
    {
      var person = await _serviceManager.People.GetPersonByIdAsync(request.Id);
      if (person == null)
      {
        throw new NoPersonExistsException(request.Id);
      }

      var result = _mapper.Map<PersonByIdResult>(person);

      return result;
    }
  }
}
