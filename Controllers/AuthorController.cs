using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookStore.Data.Services;
using MyBookStore.Data.ViewModel;

namespace MyBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorServices authorServices;
        public AuthorController(AuthorServices authorServices)
        {
            this.authorServices = authorServices;
        }
        [HttpPost("AddNewAuthor")]
        public IActionResult AddAuthor(AuthorVM author)
        {
            authorServices.AddAuthor(author);
            return Ok();
        }
    }
}
