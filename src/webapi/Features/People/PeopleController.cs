using MediatR;
using Microsoft.AspNetCore.Mvc;
using webapi.Features.People.Exceptions;
using webapi.Features.People.Queries;

namespace webapi.Features.People;

[Route("api/[controller]")]
[ApiController]
public class PeopleController : ControllerBase
{
  private readonly IMediator _mediator;

  public PeopleController(IMediator mediator)
  {
    _mediator = mediator;
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<GetPersonById.PersonByIdResult>> GetPersonById(int id)
  {
    try
    {
      var query = new GetPersonById.GetPersonByIdQuery {  Id = id };

      var result = await _mediator.Send(query);

      return Ok(result);
    }
    catch (NoPersonExistsException ex)
    {
      return Conflict(new {ex.Message});
    }
  }

}
