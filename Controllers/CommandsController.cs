
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Commander.Models;
using Commander.Data;

namespace Commander.Controllers
{
    // the ControllerBase doesn't have View support
    // [Route("api/[controller]")] <-- automatically aligns with class name
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        // private readonly MockCommanderRepo _repo = new MockCommanderRepo();
        private readonly ICommanderRepo _repo;

        // dependency injection
        public CommandsController(ICommanderRepo repo)
        {
            _repo = repo;
        }

        // decorate to indicate which HTTP verb is involved
        [HttpGet]
        public ActionResult<IEnumerable<Command>> index()
        {
            var commandItems = _repo.GetAllCommands();
            return Ok(commandItems);
        }

        [HttpGet("{id}")]
        public ActionResult<Command> show(int id)
        {
            var commandItem = _repo.GetCommandById(id);
            return Ok(commandItem);
        }
    }
}