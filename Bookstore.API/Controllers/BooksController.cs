using Bookstore.Application.Interfaces;
using Bookstore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _repository;

        public BooksController(IBookRepository repository) => _repository = repository;

        [HttpGet] public async Task<IActionResult> GetAll() => Ok(await _repository.GetAllAsync());
        [HttpGet("{id}")] public async Task<IActionResult> Get(int id) => Ok(await _repository.GetByIdAsync(id));
        [HttpPost] public async Task<IActionResult> Add([FromBody] Book book) { await _repository.AddAsync(book); return Ok(); }
        [HttpPut] public async Task<IActionResult> Update([FromBody] Book book) { await _repository.UpdateAsync(book); return Ok(); }
        [HttpDelete("{id}")] public async Task<IActionResult> Delete(int id) { await _repository.DeleteAsync(id); return Ok(); }
    }
}

