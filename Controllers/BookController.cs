using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookStore.Data.Models;
using MyBookStore.Data.Services;
using MyBookStore.Data.ViewModel;

namespace MyBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private BookServices bookServices;
        public BookController(BookServices bookServices)
        {
            this.bookServices = bookServices;
        }
        [HttpPost("AddBook")]
        public IActionResult AddBook(BookVM book)
        {
            bookServices.addBook(book);
            return Ok();
        }
        [HttpGet("GetBook")]
        public IActionResult GetBooks()
        {
            var books = bookServices.GetBooks();
            return Ok(books);
        }
        [HttpGet("getById/{id}")]
        public IActionResult GetById(int id)
        {
            var book = bookServices.getByID(id);
            return Ok(book);
        }
        [HttpPut("update/{id}")]
        public IActionResult UpdateBook (int id , BookVM book)
        {
            var bookUpdated = bookServices.UpdateBook(id, book);
            return Ok(bookUpdated);
        }
        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeletebyId(int id)
        {
            bookServices.DeleteById(id);
            return Ok();
        }
    }
}
