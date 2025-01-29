using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;

namespace DigitalVaultAPI.Infrastracture.Repository.Request
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public Task<UserEntity> AddUserAsync(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }

        public UserEntity DeleteUserAsync(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public UserEntity UpdateUserAsync(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }
    }
}