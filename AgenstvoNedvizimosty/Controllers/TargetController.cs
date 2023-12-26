using AgenstvoNedvizimosty.Context;
using AgenstvoNedvizimosty.Context.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class TargetController : ControllerBase
        {
        private readonly IAgenstvoNedvizimostyContext context;

        public TargetController(IAgenstvoNedvizimostyContext context)
        {
            this.context = context;
        }
        [HttpGet]
            public IActionResult GetAllTargetController()
            {
 
                var targetlist = context.Targets.ToList();

                return Ok(targetlist);
            }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var targetlist = context.Targets.FirstOrDefault(x => x.Id == id);
            return Ok(targetlist);
        }
    }
    }

