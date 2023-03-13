using webapi.Features.Employee;
using webapi.Features.People;

namespace webapi.ServiceManager;

public interface IServiceManager
{
  IPeopleService People { get; }
  IEmployeeService Employee { get; }
}
