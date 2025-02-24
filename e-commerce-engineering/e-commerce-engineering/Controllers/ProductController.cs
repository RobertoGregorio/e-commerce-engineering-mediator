using Microsoft.AspNetCore.Mvc;

namespace e_commerce_engineering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController() { }

        public IActionResult Get()
        {
            return Ok("hello word"); 
        }
    }
}
