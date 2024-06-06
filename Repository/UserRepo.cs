using Microsoft.EntityFrameworkCore;
using MyApplication.Database;
using MyApplication.Enties;

// IUserRepository.cs
namespace MyApplication.Repository
{
    public interface IUserRepository : IBaseRepository<User, string>
    {


        User GetByAccountId(string accountId);

    }
}

// UserRepository.cs
namespace MyApplication.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetByAccountId(string accountId)
        {

            var user = (from u in _context.Users
            join a in _context.Accounts on u.Id equals a.UserId
            where a.Id == accountId
            select u)
           .FirstOrDefault();


            return user;
        }


        public User GetById(string id)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}






