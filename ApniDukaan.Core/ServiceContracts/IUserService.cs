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

        /// <summary>
        /// Retrieves user details based on the provided user ID and returns a UserDTO object.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        Task<UserDTO?> GetUserByUserID(Guid? userID);
    }
}
