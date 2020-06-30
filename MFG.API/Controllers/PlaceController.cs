using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.PlaceCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public PlaceController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<PlaceController>
        [HttpGet]
        public IActionResult Get([FromQuery] PlaceSearch search, [FromServices] IGetPlacesQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<PlaceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlaceController>
        [HttpPost]
        public IActionResult Post([FromBody] PlaceDto dto, [FromServices] ICreatePlaceCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("uneto");
        }

        // PUT api/<PlaceController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] PlaceDto dto, [FromServices] IEditPlaceCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<PlaceController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeletePlaceCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}