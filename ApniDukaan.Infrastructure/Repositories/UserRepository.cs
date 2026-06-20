using ApniDukaan.Core.Common;
using ApniDukaan.Core.Entities;
using ApniDukaan.Core.RepositoryContracts;

namespace ApniDukaan.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            // Generate new Guid for every new unique UserId
            user.UserId = Guid.NewGuid();

            return user;
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password)
        {
            return new ApplicationUser
            {
                UserId = Guid.NewGuid(),
                Email = email,
                Password = password,
                PersonName = "",
                Gender = nameof(GenderOptions.Male)
            };
        }
    }
}
