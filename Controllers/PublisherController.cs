using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBookStore.Data.Services;
using MyBookStore.Data.ViewModel;

namespace MyBookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private PublisherServices publisherServices;
        public PublisherController(BookServices bookServices)
        {
            this.publisherServices = publisherServices;
        }
        [HttpPost("AddPublisher")]
        public IActionResult AddPublisher(PublisherVM publisher)
        {
            publisherServices.AddPublisher(publisher);
            return Ok();
        }
    }

}
