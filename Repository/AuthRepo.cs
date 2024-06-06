using MyApplication.Database;
using MyApplication.Enties;

// IUserRepository.cs
namespace MyApplication.Repository
{
    public interface IAuthRepository
    {
        void login(string username, string password);
        void logout();
    }
}

// UserRepository.cs
namespace MyApplication.Repository
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void logout()
        {
            throw new NotImplementedException();
        }
    }
}
