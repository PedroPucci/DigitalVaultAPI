using DigitalVaultAPI.Application.ExtensionError;
using DigitalVaultAPI.Application.Services.Interfaces;
using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW;

namespace DigitalVaultAPI.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly IRepositoryUoW _repositoryUoW;

        public TransferService(IRepositoryUoW repositoryUoW)
        {
            _repositoryUoW = repositoryUoW;
        }

        public Task<Result<TransferEntity>> AddTransferAsync(TransferEntity transferEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransferEntity>> GetAllTransfersAsync()
        {
            throw new NotImplementedException();
        }
    }
}