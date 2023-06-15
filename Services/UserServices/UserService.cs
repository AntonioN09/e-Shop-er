using AutoMapper;
using EShop.Controllers.Jwt;
using EShop.Models;
using EShop.Models.DTOs;
using EShop.Models.Enums;
using EShop.Repositories.UserRepositories;
using BCryptNet = BCrypt.Net.BCrypt;

namespace EShop.Services.UserServices
{
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public IJwtUtils _jwtUtils;
        public IMapper _mapper;

        public UserService(IUserRepository userRepository, IJwtUtils jwtUtils, IMapper mapper)
        {
            _userRepository = userRepository;
            _jwtUtils = jwtUtils;
            _mapper = mapper;
        }

        public async Task<List<User>> GetAll()
        {
            return await _userRepository.GetAll();
        }

        public async Task AddUser(User newUser)
        {
            await _userRepository.CreateAsync(newUser);
            await _userRepository.SaveAsync();
        }

        public async Task DeleteUser(Guid userId)
        {
            var userToDelete = await _userRepository.FindByIdAsync(userId);
            _userRepository.Delete(userToDelete);
            await _userRepository.SaveAsync();
        }
        public async Task Create(UserAuthRequestDto user)
        {
            var newDBUser = _mapper.Map<User>(user);
            newDBUser.PasswordHash = BCryptNet.HashPassword(user.Password);
            newDBUser.Role = Role.User;

            await _userRepository.CreateAsync(newDBUser);
            await _userRepository.SaveAsync();
        }

        public UserAuthResponseDto Authenticate(UserAuthRequestDto model)
        {
            var manager = _userRepository.FindByName(model.FirstName);
            if (manager == null || !BCryptNet.Verify(model.Password, manager.PasswordHash))
            {
                return null;
            }

            var jwtToken = _jwtUtils.GenerateJwtToken(manager);
            return new UserAuthResponseDto(manager, jwtToken);
        }

        public User GetById(Guid id)
        {
            return _userRepository.FindById(id);
        }
    }
}
