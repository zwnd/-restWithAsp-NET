using Microsoft.AspNetCore.Mvc;
using restWithAspNET.model;
using restWithAspNET.services.implematation;

namespace restWithAspNET.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class personsController : Controller
    {
        private IPersonService _personService;

        public personsController(IPersonService personService)
        {
            _personService = personService;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personService.findAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var persona = _personService.findbyId(id);
            if (persona == null) return NotFound();
            return Ok(persona);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]persona persona)
        {
           
            if (persona == null) return NotFound();
            return new ObjectResult(_personService.Create(persona));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]persona persona)
        {
            if (persona == null) return NotFound();
            return new ObjectResult(_personService.Update(persona));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personService.Delete(id);
            return NoContent();
        }
    }
}
