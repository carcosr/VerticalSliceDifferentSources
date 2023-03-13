using webapi.Features.People;

namespace webapi.ServiceManager;

public interface IServiceManager
{
  IPeopleService People { get; }
}
