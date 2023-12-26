using AgenstvoNedvizimosty.Context;
using AgenstvoNedvizimosty.Context.Contracts;
using AgenstvoNedvizimosty.Context.Contracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TuristController : ControllerBase
    {
        private readonly IAgenstvoNedvizimostyContext context;

        public TuristController(IAgenstvoNedvizimostyContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetAllTuristController()
        {
    
            var turistlist = context.Turists.ToList();

            return Ok(turistlist);
        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var turistlist = context.Turists.FirstOrDefault(x => x.Id == id);
            return Ok(turistlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group1 = context.Turists.FirstOrDefault(x => x.Id == id); 
            if (group1 != null)
            {
                context.Turists.Remove(group1);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Turist model)
        {
            var item1 = new Turist
            {
                Id = Guid.NewGuid(),
                NFO = model.NFO,
                SeriesAndNomerPass = model.SeriesAndNomerPass,
                email = model.email,
                PhoneNumber = model.PhoneNumber,

            }; context.Turists.Add(item1);
            context.SaveChanges(); return Ok(item1);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Turist model)
        {
            var group1 = context.Turists.FirstOrDefault(x => x.Id == Id); 

                if (group1 != null)
                {
                    return NotFound();
                }

                group1.NFO = model.NFO; 
                group1.SeriesAndNomerPass = model.SeriesAndNomerPass;
                group1.email = model.email;
                group1.PhoneNumber = model.PhoneNumber;
                context.SaveChanges();
                return Ok(group1);
        }
    }
}

