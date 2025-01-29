using DigitalVaultAPI.Application.ExtensionError;
using DigitalVaultAPI.Application.Services.Interfaces;
using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW;

namespace DigitalVaultAPI.Application.Services
{
    public class BalanceService : IBalanceService
    {
        private readonly IRepositoryUoW _repositoryUoW;

        public BalanceService(IRepositoryUoW repositoryUoW)
        {
            _repositoryUoW = repositoryUoW;
        }

        public Task<Result<BalanceEntity>> AddBalanceAsync(BalanceEntity balanceEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<BalanceEntity>> GetAllBalancesAsync()
        {
            throw new NotImplementedException();
        }
    }
}