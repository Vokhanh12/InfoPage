using MyApplication.Enties;
using MyApplication.Repository;

namespace MyApplication.Service
{
    public interface IHomeService
    {
        List<User> SelectUser();
    }

    public class HomeService : IHomeService
    {
        private readonly IUserRepository _userRepo;
        private readonly IAuthRepository _authRepo;

        public HomeService(IUserRepository userRepo, IAuthRepository authRepo)
        {
            _userRepo = userRepo;
            _authRepo = authRepo;
        }

        public List<User> SelectUser()
        {
            try
            {
                return _userRepo.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving users", ex);
            }
        }
    }
}