using Domain;
using Microsoft.EntityFrameworkCore;
using webapi.Data.SQL;

namespace webapi.Features.People;

public class PeopleService : IPeopleService
{
  private readonly SqlDbContext _dbContext;

  public PeopleService(SqlDbContext sqlDbContext)
  {
    _dbContext = sqlDbContext;
  }

  public async Task<Person> GetPersonByIdAsync(int id)
  {
    var data = await _dbContext.People
      .Where(x => x.Id == id)
      .FirstOrDefaultAsync();

    return data;
  }
}
