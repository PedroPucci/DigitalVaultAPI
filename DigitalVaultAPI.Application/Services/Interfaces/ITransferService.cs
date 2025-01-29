using DigitalVaultAPI.Application.ExtensionError;
using DigitalVaultAPI.Domain.Entities;

namespace DigitalVaultAPI.Application.Services.Interfaces
{
    public interface ITransferService
    {
        Task<Result<TransferEntity>> AddTransferAsync(TransferEntity transferEntity);
        Task<List<TransferEntity>> GetAllTransfersAsync();
    }
}