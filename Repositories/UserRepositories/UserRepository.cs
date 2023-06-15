using Microsoft.EntityFrameworkCore;
using EShop.Data;
using EShop.Models;
using EShop.Repositories.GenericRepository;

namespace EShop.Repositories.UserRepositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context) { }

        public User FindByName(string name)
        {
            return _table.FirstOrDefault(x => x.FirstName == name);
        }
    }
}
