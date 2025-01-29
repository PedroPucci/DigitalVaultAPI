using DigitalVaultAPI.Application.ExtensionError;
using DigitalVaultAPI.Application.Services.Interfaces;
using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW;

namespace DigitalVaultAPI.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryUoW _repositoryUoW;

        public UserService(IRepositoryUoW repositoryUoW)
        {
            _repositoryUoW = repositoryUoW;
        }

        public Task<Result<UserEntity>> AddUserAsync(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserEntity>> GetAllUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Result<UserEntity>> UpdateUserAsync(UserEntity userEntity)
        {
            throw new NotImplementedException();
        }
    }
}