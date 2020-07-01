using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.TicketReservationCommands;
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
    public class TicketReservationController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public TicketReservationController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<TicketReservationController>
        [HttpGet]
        public IActionResult Get([FromQuery] TicketReservationSearch search, [FromServices] IGetTicketReservationsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<TicketReservationController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id, [FromServices] IGetTicketReservationQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, id));
        }

        // POST api/<TicketReservationController>
        [HttpPost]
        public IActionResult Post([FromBody] TicketReservationCreateDto dto, [FromServices] ICreateTicketReservationCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("radi");
        }

        // PUT api/<TicketReservationController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TicketReservationDto dto, [FromServices] IEditTicketReservationCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<TicketReservationController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteTicketReservationCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult Put(int id, [FromServices] IPickTicketReservationCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}