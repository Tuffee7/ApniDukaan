using ApniDukaan.Core.Common;
using ApniDukaan.Core.Entities;
using ApniDukaan.Core.RepositoryContracts;
using ApniDukaan.Infrastructure.DBContext;

namespace ApniDukaan.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationUserDbContext _dbContext;

        public UserRepository(ApplicationUserDbContext dbContext)
        {
            _dbContext = dbContext;
        }

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
                PersonName = "dummy-person-name",
                Gender = nameof(GenderOptions.Male)
            };
        }
    }
}
