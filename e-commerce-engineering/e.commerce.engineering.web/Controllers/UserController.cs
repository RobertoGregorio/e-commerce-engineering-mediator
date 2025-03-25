using e.commerce.engineering.domain.Repositorys;
using e_commerce_enginerring.application.Contracts.Request.CreateUserAggregate;
using Microsoft.AspNetCore.Mvc;

namespace e.commerce.engineering.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class UserController(IUnitOfWork unitOfWork) : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork = unitOfWork;

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string username)
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

        [HttpPost]
        public async Task<IActionResult> Post(CreateUserAggregateRequest createUserRequest)
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
