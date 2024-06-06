using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
using MyApplication.Enties;
using MyApplication.Repository;

namespace MyApplication.Service
{
    public interface ILoginService
    {
        User Authenticate(string username, string password);
    }

    public class LoginService : ILoginService
    {
        private readonly IAuthRepository _authRepo;
        private readonly IAccountRepository _accountRepo;
        private readonly IUserRepository _userRepo;


        public LoginService(IAuthRepository authRepo, IAccountRepository accountRepo, IUserRepository userRepo)
        {
            _authRepo = authRepo;
            _accountRepo = accountRepo;
            _userRepo = userRepo;
        }

        public User Authenticate(string username, string password)
        {
            try
            {

                Account account = _accountRepo.GetByUsernameAndPassword(username, password);

                if (account != null)
                {
                    
                    User user = _userRepo.GetByAccountId(account.Id);


                    if(user != null){

                      return user;

                    }

                    throw new Exception("User null");

                }
                else
                {

                    throw new Exception("Account null");

                }

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving users", ex);
            }
        }

    }
}