
namespace webapi.Features.Employee;

public interface IEmployeeService
{
  public Task<Domain.Employee> GetEmployeeByIdAsync(int id);
  public Task<string> GetDailyMessage(int id);
}
