using Microsoft.EntityFrameworkCore;
using MyApplication.Enties;
namespace MyApplication.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

         public DbSet<User> Users { get; set; }

         public DbSet<Account> Accounts{get; set;}

    }
}