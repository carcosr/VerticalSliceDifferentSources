using webapi.Data.SQL;
using webapi.Features.People;

namespace webapi.ServiceManager;

public class ServiceManager : IServiceManager
{
  private readonly SqlDbContext _dbContext;

  private IPeopleService _peopleService;

    public ServiceManager(SqlDbContext context)
    {
        _dbContext = context;
    }

  public IPeopleService People
  { 
    get
    {
      if (_peopleService == null)
        _peopleService = new PeopleService(_dbContext);

      return _peopleService;
    }
  }


}
