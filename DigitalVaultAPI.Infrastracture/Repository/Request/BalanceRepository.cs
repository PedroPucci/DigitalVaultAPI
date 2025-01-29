using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigitalVaultAPI.Infrastracture.Repository.Request
{
    public class BalanceRepository : IBalanceRepository
    {
        private readonly DataContext _context;

        public BalanceRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<BalanceEntity> AddBalanceAsync(BalanceEntity balanceEntity)
        {
            if (balanceEntity is null)
                throw new ArgumentNullException(nameof(balanceEntity), "Balance cannot be null");

            var result = await _context.BalanceEntity.AddAsync(balanceEntity);
            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<BalanceEntity>> GetAllBalancesAsync()
        {
            return await _context.BalanceEntity
                .OrderBy(balanceEntity => balanceEntity.Id)
                .Select(balanceEntity => new BalanceEntity
                {
                    Id = balanceEntity.Id,
                    CreateDate = balanceEntity.CreateDate
                }).ToListAsync();
        }
    }
}