﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.TicketCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public TicketController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<TicketController>
        [HttpGet]
        public IActionResult Get([FromQuery] TicketSearch search, [FromServices] IGetTicketsQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TicketController>
        [HttpPost]
        public IActionResult Post([FromBody] TicketDto dto, [FromServices] ICreateTicketCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("uneto");
        }

        // PUT api/<TicketController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] TicketDto dto, [FromServices] IEditTicketCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<TicketController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteTicketCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }
    }
}