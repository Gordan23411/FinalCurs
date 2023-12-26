using AgenstvoNedvizimosty.Context;
using AgenstvoNedvizimosty.Context.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.RegularExpressions;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    namespace AgenstvoNedvizimosty.Api.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PutTargetItemController : ControllerBase
        {
            private readonly IAgenstvoNedvizimostyContext context;

            public PutTargetItemController(IAgenstvoNedvizimostyContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public IActionResult GetAllPutTargerItemController()
            {

                var puttargetlist = context.PutTargetItems.ToList();

                return Ok(puttargetlist);
            }
            [HttpGet("{id:guid}")]
            public IActionResult Get(Guid id)
            {
                var puttargetlist = context.PutTargetItems.FirstOrDefault(x => x.Id == id);
                return Ok(puttargetlist);
            }
        }
    }

}
