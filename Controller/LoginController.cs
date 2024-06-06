
using MyApplication.Enties;
using MyApplication.Service;

namespace MyApplication.Controller
{
    public class LoginController
    {
        private ILoginService _service;

        public LoginController(ILoginService service)
        {
            _service = service;
        }

        public User Login(string username, string password){
            return _service.Authenticate(username, password);
        }
      
    }
}


