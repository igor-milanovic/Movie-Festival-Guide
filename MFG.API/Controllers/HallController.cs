using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.HallCommands;
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
    public class HallController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public HallController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<HallController>
        [HttpGet]
        public IActionResult Get([FromQuery] HallSearch search, [FromServices] IGetHallsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<HallController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromServices] IGetHallQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        // POST api/<HallController>
        [HttpPost]
        public IActionResult Post([FromBody] HallCreateDto dto, [FromServices] ICreateHallCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("uneto");
        }

        // PUT api/<HallController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] HallDto dto, [FromServices] IEditHallCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<HallController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteHallCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}