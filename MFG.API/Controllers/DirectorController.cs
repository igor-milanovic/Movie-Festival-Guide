using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.DirectorCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;
        private readonly IApplicationActor _actor;

        public DirectorController(UseCaseExecutor executor, IApplicationActor actor)
        {
            _executor = executor;
            _actor = actor;
        }

        // GET: api/<DirectorController>
        [HttpGet]
        public IActionResult Get([FromQuery] DirectorSearch search, [FromServices] IGetDirectorsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<DirectorController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DirectorController>
        [HttpPost]
        public IActionResult Post([FromBody] DirectorDto dto, [FromServices] ICreateDirectorCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("radi");
        }

        // PUT api/<DirectorController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] DirectorDto dto, [FromServices] IEditDirectorCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<DirectorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteDirectorCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}