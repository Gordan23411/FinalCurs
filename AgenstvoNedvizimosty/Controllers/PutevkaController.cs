using AgenstvoNedvizimosty.Context;
using AgenstvoNedvizimosty.Context.Contracts;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PutevkaController : ControllerBase
    {
        private readonly IAgenstvoNedvizimostyContext context;

        public PutevkaController(IAgenstvoNedvizimostyContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetAllPutevka() 
        {
            var turistlist = context.Putevkas.ToList();

            return Ok(turistlist);
        }

        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var turistlist = context.Putevkas.FirstOrDefault(x => x.Id == id);
            return Ok(turistlist);
        }
    }
}
