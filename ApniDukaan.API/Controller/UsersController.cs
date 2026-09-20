using ApniDukaan.Core.ResponseDTO;
using ApniDukaan.Core.ServiceContracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApniDukaan.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        // GET /api/users/{userID}
        [HttpGet("{userID}")]
        public async Task<IActionResult> GetUserByUserID(Guid? userID)
        {
            UserDTO? user = await _userService.GetUserByUserID(userID);

            if (user == null)
                return NotFound();

            return Ok(user);
        }
    }
}
