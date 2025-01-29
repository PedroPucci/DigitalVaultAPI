using DigitalVaultAPI.Domain.Entities;

namespace DigitalVaultAPI.Infrastracture.Repository.Interfaces
{
    public interface ITransferRepository
    {
        Task<TransferEntity> AddTransferAsync(TransferEntity transferEntity);
        Task<List<TransferEntity>> GetAllTransfersAsync();
    }
}