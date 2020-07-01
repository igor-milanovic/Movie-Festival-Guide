using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.CityCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly IApplicationActor actor;
        private readonly UseCaseExecutor _executor;

        public CityController(IApplicationActor actor, UseCaseExecutor executor)
        {
            this.actor = actor;
            this._executor = executor;
        }

        // GET: api/<CityController>
        [HttpGet]
        public IActionResult Get([FromQuery] CitySearch search, [FromServices] IGetCitiesQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromServices] IGetCityQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        [HttpPost]
        // POST api/<CityController>
        public IActionResult Post([FromBody] CityCreateDto obj, [FromServices] ICreateCityCommand command)
        {
            _executor.ExecuteCommand(command, obj);

            return Ok("radi");
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] EditCityDto dto, [FromServices] IEditCityCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteCityCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}