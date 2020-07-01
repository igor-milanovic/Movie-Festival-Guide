using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.ProjectionCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectionController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public ProjectionController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<ProjectionController>
        [HttpGet]
        public IActionResult Get([FromQuery] ProjectionSearch search, [FromServices] IGetProjectionsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<ProjectionController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromServices] IGetProjectionQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        [Authorize]
        // POST api/<ProjectionController>
        [HttpPost]
        public IActionResult Post([FromBody] ProjectionCreateDto dto, [FromServices] ICreateProjectionCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("radi");
        }

        [Authorize]
        // PUT api/<ProjectionController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProjectionDto dto, [FromServices] IEditProjectionCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        [Authorize]
        // DELETE api/<ProjectionController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteProjectionCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}