using AgenstvoNedvizimosty.Context;
using AgenstvoNedvizimosty.Context.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurOperController : ControllerBase
    {
        private readonly IAgenstvoNedvizimostyContext context;

        public TurOperController(IAgenstvoNedvizimostyContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetAllTurOperController()
        {
           
            var turOper = context.TurOpers.ToList();

            return Ok(turOper);
        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var turOper = context.TurOpers.FirstOrDefault(x => x.Id == id);
            return Ok(turOper);
        }
    }
}
