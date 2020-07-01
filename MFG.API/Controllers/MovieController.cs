using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.MovieCommands;
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
    public class MovieController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public MovieController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<MovieController>
        [HttpGet]
        public IActionResult Get([FromQuery] MovieSearch search, [FromServices] IGetMoviesQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<MovieController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromServices] IGetMovieQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        [Authorize]
        // POST api/<MovieController>
        [HttpPost]
        public IActionResult Post([FromBody] MovieCreateDto dto, [FromServices] ICreateMovieCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("uneot");
        }

        [Authorize]
        // PUT api/<MovieController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MovieDto dto, [FromServices] IEditMovieCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        [Authorize]
        // DELETE api/<MovieController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteMovieCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}