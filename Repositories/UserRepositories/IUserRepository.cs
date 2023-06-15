using EShop.Models;
using EShop.Repositories.GenericRepository;

namespace EShop.Repositories.UserRepositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User FindByName(string name);
    }
}
