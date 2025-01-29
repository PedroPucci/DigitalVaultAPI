using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigitalVaultAPI.Infrastracture.Repository.Request
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<UserEntity> AddUserAsync(UserEntity userEntity)
        {
            if (userEntity is null)
                throw new ArgumentNullException(nameof(userEntity), "User cannot be null");

            var result = await _context.UserEntity.AddAsync(userEntity);

            //if (userEntity.Balance is null)
            //    await AddBalanceAsync(accountUser);

            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public UserEntity DeleteUserAsync(UserEntity userEntity)
        {
            var response = _context.UserEntity.Remove(userEntity);
            return response.Entity;
        }

        public UserEntity UpdateUserAsync(UserEntity userEntity)
        {
            var response = _context.UserEntity.Update(userEntity);
            return response.Entity;
        }

        public async Task<List<UserEntity>> GetAllUsersAsync()
        {
            return await _context.UserEntity
                .OrderBy(accountUser => accountUser.Name)
                .Select(accountUser => new UserEntity
                {
                    Id = accountUser.Id,
                    Name = accountUser.Name,
                    Email = accountUser.Email
                }).ToListAsync();
        }
    }
}