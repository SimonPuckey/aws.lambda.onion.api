using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Organisation.Update
{
  public class Controller : ControllerBase
  {
    [HttpPost("organisation")]
    public IActionResult CreateOrganisation(Command command)
    {
      return Ok();
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
      var t0 = value;
    }



    //TODO : need to implement rest of doamin
    // public HttpController (){}

    // [HttpPost]
    // public async Task<IActionResult> CreateOrganisation(CreateOrganisation cmd)
    // {
    //     if (!cmd.IsValid)
    //     {
    //         return BadRequest("One or more parameters is invalid.");
    //     }

    //     await _hnlr.HandleAsync(cmd);
    //     return CreatedAtAction(nameof(GetOrganisation), new { id = cmd.Id }, cmd.Id);
    // }
  }
}