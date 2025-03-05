using e.commerce.engineering.domain.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace e.commerce.engineering.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IUnitOfWork unitOfWork) : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork = unitOfWork;

        public IActionResult Get()
        {
            return Ok("hello word"); 
        }
    }
}
