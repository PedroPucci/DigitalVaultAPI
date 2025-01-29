using DigitalVaultAPI.Application.ExtensionError;
using DigitalVaultAPI.Domain.Entities;

namespace DigitalVaultAPI.Application.Services.Interfaces
{
    public interface IBalanceService
    {
        Task<Result<BalanceEntity>> AddBalanceAsync(BalanceEntity balanceEntity);
        Task<List<BalanceEntity>> GetAllBalancesAsync();
    }
}