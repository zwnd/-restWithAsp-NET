using Microsoft.AspNetCore.Mvc;
using restWithAspNET.model;
using restWithAspNET.Business.implematation;
using restWithAspNET.Business;

namespace restWithAspNET.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class personsController : Controller
    {
        private IPersonBusiness _personBusiness;

        public personsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.findAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _personBusiness.findbyId(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]person person)
        {
           
            if (person == null) return NotFound();
            return new ObjectResult(_personBusiness.Create(person));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]person person)
        {
            if (person == null) return NotFound();
            return new ObjectResult(_personBusiness.Update(person));
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
