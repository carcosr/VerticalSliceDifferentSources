using MediatR;
using Microsoft.AspNetCore.Mvc;
using webapi.Features.Employee.Queries;
using webapi.Features.People.Exceptions;
using webapi.Features.People.Queries;

namespace webapi.Features.Employee;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
  private readonly IMediator _mediator;

  public EmployeeController(IMediator mediator)
  {
    _mediator = mediator;
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<GoodMorning.GoodMorningQuery>> GetMessageForEmployeeById(int id)
  {
    try
    {
      var query = new GoodMorning.GoodMorningQuery { Id = id };

      var result = await _mediator.Send(query);

      return Ok(result);
    }
    catch (NoEmployeeExistsException ex)
    {
      return Conflict(new { ex.Message });
    }
  }

}
