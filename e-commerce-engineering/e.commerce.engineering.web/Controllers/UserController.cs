using e.commerce.engineering.domain.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace e.commerce.engineering.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController(IUnitOfWork unitOfWork) : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork = unitOfWork;

        [HttpGet]
        public async Task<IActionResult> GetByUsername(string username)
        {
            try
            {
                var user = await unitOfWork.UserRepository.GetUserByUsername(username);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
