using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.FestivalCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FestivalController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;
        private readonly IApplicationActor _actor;

        public FestivalController(UseCaseExecutor executor, IApplicationActor actor)
        {
            _executor = executor;
            _actor = actor;
        }

        // GET: api/<FestivalController>
        [HttpGet]
        public IActionResult Get([FromQuery] FestivalSearch search, [FromServices] IGetFestivalsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<FestivalController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FestivalController>
        [HttpPost]
        public IActionResult Post([FromBody] EditFestivalDto dto, [FromServices] ICreateFestivalCommand command)
        {
            _executor.ExecuteCommand(command, dto);

            return Ok("radi");
        }

        // PUT api/<FestivalController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditFestivalDto dto, [FromServices] IEditFestivalCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<FestivalController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteFestivalCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}