using bookshop.Models;
using bookshop.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bookshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            var obj =_service.GetAll().ToList();
            return Ok(obj);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public Author Get(int id)
        {
            return _service.GetById(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Author value)
        {
            _service.add(value);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody]Author author )
        {
            _service.update(author);
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var obj =_service.GetById(id);
            _service.delete(obj);
        }
    }
}
