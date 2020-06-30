using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.CityCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor executor;

        public CityController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this.executor = executor;
        }

        // GET: api/<CityController>
        [HttpGet]
        public IActionResult Get([FromQuery] CitySearch search, [FromServices] IGetCitiesQuery query)
        {
            return Ok(executor.ExecuteQuery(query, search));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CityController>
        public IActionResult Post([FromBody] CityDto obj, [FromServices] ICreateCityCommand command)
        {
            executor.ExecuteCommand(command, obj);

            return Ok("radi");
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditCityDto dto, [FromServices] IEditCityCommand command)
        {
            dto.Id = id;
            executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteCityCommand command)
        {
            executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}