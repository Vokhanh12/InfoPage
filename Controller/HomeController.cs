
using MyApplication.Enties;
using MyApplication.Service;

namespace MyApplication.Controller
{
    public class HomeController
    {
        private IHomeService _service;

        public HomeController(IHomeService service)
        {
            _service = service;
        }

        public List<User> getAllUsers(){
            return _service.SelectUser();
        }
    }
}


