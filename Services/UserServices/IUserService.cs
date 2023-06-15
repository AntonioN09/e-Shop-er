using EShop.Models;
using EShop.Models.DTOs;

namespace EShop.Services.UserServices
{
    public interface IUserService
    {
        public Task<List<User>> GetAll();
        public Task AddUser(User newUser);
        public Task DeleteUser(Guid userId);
        Task Create(UserAuthRequestDto newUser);
        UserAuthResponseDto Authenticate(UserAuthRequestDto model);
        User GetById(Guid id);
    }
}
