namespace webapi.Features.People.Exceptions;

public class NoPersonExistsException : Exception
{
  public int PersonId { get; set; }

    public NoPersonExistsException(int personId) : 
      base($"No person with id: {personId} found;")
    {
        PersonId = personId;
    }
}
