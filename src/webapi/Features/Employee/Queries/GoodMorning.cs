using MediatR;
using webapi.Features.People.Exceptions;
using webapi.ServiceManager;

namespace webapi.Features.Employee.Queries;

public class GoodMorning
{
  //Input
  public class GoodMorningQuery : IRequest<GoodMorningResult>
  {
    public int Id { get; set; }
  }

  //Output
  public class GoodMorningResult
  {
    public string Message { get; set; }
  }

  //Handler
  public class Handler : IRequestHandler<GoodMorningQuery, GoodMorningResult>
  {
    private readonly IServiceManager _serviceManager;

    public Handler(IServiceManager serviceManager)
    {
      _serviceManager = serviceManager;
    }

    public async Task<GoodMorningResult> Handle(GoodMorningQuery request, CancellationToken cancellationToken)
    {
      var employee = await _serviceManager.Employee.GetEmployeeByIdAsync(request.Id);
      if (employee == null)
      {
        throw new NoEmployeeExistsException(request.Id);
      }

      var person = await _serviceManager.People.GetPersonByIdAsync(employee.PersonId);
      var message = "este es el mensaje de hoy";

      var result = new GoodMorningResult
      {
        Message = string.Format("Good morning {0}, today you have to know that {1}", person.Name, message)
      };

      return result;
    }

  }

}
