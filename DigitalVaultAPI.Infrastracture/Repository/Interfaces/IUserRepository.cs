using DigitalVaultAPI.Domain.Entities;

namespace DigitalVaultAPI.Infrastracture.Repository.Interfaces
{
    public interface IUserRepository
    {
        Task<UserEntity> AddUserAsync(UserEntity userEntity);
        UserEntity UpdateUserAsync(UserEntity userEntity);
        UserEntity DeleteUserAsync(UserEntity userEntity);
        Task<List<UserEntity>> GetAllUsersAsync();
    }
}