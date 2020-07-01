using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.LocationCommands;
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
    public class LocationController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public LocationController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<LocationController>
        [HttpGet]
        public IActionResult Get([FromQuery] LocationSearch search, [FromServices] IGetLocationsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromServices] IGetLocationQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        // POST api/<LocationController>
        [HttpPost]
        public IActionResult Post([FromBody] LocationCreateDto dto, [FromServices] ICreateLocationCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("Uneto");
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] LocationDto dto, [FromServices] IEditLocationCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteLocationCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}