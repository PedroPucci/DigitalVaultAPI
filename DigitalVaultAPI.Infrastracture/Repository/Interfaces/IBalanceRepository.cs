using DigitalVaultAPI.Domain.Entities;

namespace DigitalVaultAPI.Infrastracture.Repository.Interfaces
{
    public interface IBalanceRepository
    {
        Task<BalanceEntity> AddBalanceAsync(BalanceEntity balanceEntity);
        Task<List<BalanceEntity>> GetAllBalancesAsync();
    }
}