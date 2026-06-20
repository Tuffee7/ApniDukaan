using ApniDukaan.Core.RequestDTO;
using ApniDukaan.Core.ResponseDTO;

namespace ApniDukaan.Core.ServiceContracts
{
    public interface IUserService
    {
        /// <summary>
        /// Registers a new user with the provided registration request details and returns an authentication response.
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Register(RegisterRequest loginRequest);

        /// <summary>
        /// Logs in a user with the provided login request details and returns an authentication response.
        /// </summary>
        /// <param name="loginRequest"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Login(LoginRequest loginRequest);
    }
}
