using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;

namespace DigitalVaultAPI.Infrastracture.Repository.Request
{
    public class BalanceRepository : IBalanceRepository
    {
        private readonly DataContext _context;

        public BalanceRepository(DataContext context)
        {
            _context = context;
        }

        public Task<BalanceEntity> AddBalanceAsync(BalanceEntity balanceEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<BalanceEntity>> GetAllBalancesAsync()
        {
            throw new NotImplementedException();
        }
    }
}