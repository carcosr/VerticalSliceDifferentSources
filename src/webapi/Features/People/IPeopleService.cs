using Domain;
namespace webapi.Features.People;

public interface IPeopleService
{
  Task<Person> GetPersonByIdAsync(int id);
}
