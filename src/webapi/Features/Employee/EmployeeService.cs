

using Microsoft.EntityFrameworkCore;
using webapi.Data.SQL;

namespace webapi.Features.Employee;

public class EmployeeService : IEmployeeService
{
  private readonly SqlDbContext _dbContext;

  public EmployeeService(SqlDbContext sqlDbContext)
  {
    _dbContext = sqlDbContext;
  }

  public Task<string> GetDailyMessage(int id)
  {
    throw new NotImplementedException();
  }

  public async Task<Domain.Employee> GetEmployeeByIdAsync(int id)
  {
    var data = await _dbContext.Employees
      .Where(e => e.Id == id)
      .FirstOrDefaultAsync();

    return data;
  }
}
