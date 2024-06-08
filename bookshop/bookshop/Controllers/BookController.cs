using bookshop.Models;
using bookshop.Services.interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace bookshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult Get()
        {
            var books = _service.GetAll().ToArray();
            return Ok(books);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var book =_service.GetById(id);
            return Ok(book);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _service.add(book);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Book book)
        {
            _service.update(book);
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
