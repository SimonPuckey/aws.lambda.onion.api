using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Organisation.Update
{
  public class Controller : ControllerBase
  {
    [HttpPut("organisation/{id}")]
    public IActionResult UpdateOrganisation(Guid id, [FromBody] Command command)
    {
      command.Id = id;
      return Ok();
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