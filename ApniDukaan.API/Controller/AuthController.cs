using ApniDukaan.Core.RequestDTO;
using ApniDukaan.Core.ResponseDTO;
using ApniDukaan.Core.ServiceContracts;
using Microsoft.AspNetCore.Mvc;
using LoginRequest = ApniDukaan.Core.RequestDTO.LoginRequest;

namespace ApniDukaan.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest registerRequest)
        {
            if (registerRequest == null)
            {
                return BadRequest("Invalid registration request.");
            }

            // Add Validation logic here (e.g., check if email is valid, password strength, etc.)

            // Call the UserService to register the user
            AuthenticationResponse? authResponse = await _userService.Register(registerRequest);
            if (authResponse == null || !(authResponse.IsAuthenticated ?? false))
            {
                return Unauthorized();
            }

            return Ok(authResponse);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest loginRequest)
        {
            if (loginRequest == null)
            {
                return BadRequest("Invalid login request.");
            }

            // Add Validation logic here (e.g., check if email is valid, password is not empty, etc.)

            // Call the login service to authenticate the user
            AuthenticationResponse? authResponse = await _userService.Login(loginRequest);
            if (authResponse == null || !(authResponse.IsAuthenticated ?? false))
            {
                return Unauthorized();
            }

            return Ok(authResponse);
        }

    }
}
