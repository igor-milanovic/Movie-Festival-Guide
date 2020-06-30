﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.AdminCommands;
using MFG.Application.Commands.UserCommands;
using MFG.Application.DataTransfer;
using MFG.Application.Queries;
using MFG.Application.Searches;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public UserController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get([FromQuery] UserSearch search, [FromServices] IGetUsersQuery query)
        {
            return Ok(_executor.ExecuteQuery(query, search));
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] UserDto dto, [FromServices] ICreateUserCommand command)
        {
            _executor.ExecuteCommand(command, dto);
            return Ok("uneto");
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserDto dto, [FromServices] IEditUserCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromServices] IDeleteUserCommand command)
        {
            _executor.ExecuteCommand(command, id);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] UserRoleDto dto, [FromServices] IChangeUserRoleCommand command)
        {
            dto.Id = id;
            _executor.ExecuteCommand(command, dto);
            return NoContent();
        }
    }
}