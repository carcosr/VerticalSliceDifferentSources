namespace webapi.Data.SourceOne;

public class SourceOneService : ISourceOneService
{
  public Task<string> TellMeSomething()
  {
    return Task.FromResult("something");
  }
}
