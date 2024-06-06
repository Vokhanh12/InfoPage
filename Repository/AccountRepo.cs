using MyApplication.Database;
using MyApplication.Enties;

// IUserRepository.cs
namespace MyApplication.Repository
{
    public interface IAccountRepository : IBaseRepository<Account, string>
    {
        Account GetByUsernameAndPassword(string username, string password);

    }
}

// UserRepository.cs
namespace MyApplication.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly ApplicationDbContext _context;

        public AccountRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Account entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Account entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Account> GetAll()
        {
            throw new NotImplementedException();
        }

        public Account GetById(string id)
        {
            throw new NotImplementedException();
        }
      
        public Account GetByUsernameAndPassword(string username, string password)
        {
           return _context.Accounts.FirstOrDefault(a => a.Username == username && a.Password == password);
        }

        public void Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}






