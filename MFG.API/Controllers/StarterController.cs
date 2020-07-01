using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MFG.Application;
using MFG.Application.Commands.AdminCommands;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MFG.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StarterController : ControllerBase
    {
        private readonly UseCaseExecutor _executor;

        public StarterController(UseCaseExecutor executor)
        {
            _executor = executor;
        }

        // GET: api/<StarterController>
        [HttpGet]
        public IActionResult Get([FromServices] ISetFakeDataCommand command)
        {
            _executor.ExecuteCommand(command, 1);
            return Ok("Fake podaci su uneti");
        }
    }
}