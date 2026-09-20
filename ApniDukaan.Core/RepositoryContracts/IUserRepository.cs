using ApniDukaan.Core.Entities;

namespace ApniDukaan.Core.RepositoryContracts
{
    public interface IUserRepository
    {
        /// <summary>
        /// Adds a new user to the system.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task<ApplicationUser?> AddUser(ApplicationUser user);

        /// <summary>
        /// Retrieves a user based on the provided email and password.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);

        /// <summary>
        /// Retrieves a user based on the provided user ID.
        /// </summary>
        /// <param name="userID"></param>
        /// <returns></returns>
        Task<ApplicationUser?> GetUserByUserID(Guid? userID);
    }
}
