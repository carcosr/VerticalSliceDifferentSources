namespace webapi.Features.People.Exceptions;

public class NoEmployeeExistsException : Exception
{
  public int EmployeeId { get; set; }

  public NoEmployeeExistsException(int employeeId) :
    base($"No employee with id: {employeeId} found;")
  {
    EmployeeId = employeeId;
  }
}
