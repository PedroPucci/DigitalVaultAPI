using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;

namespace DigitalVaultAPI.Infrastracture.Repository.Request
{
    public class TransferRepository : ITransferRepository
    {
        private readonly DataContext _context;

        public TransferRepository(DataContext context)
        {
            _context = context;
        }

        public Task<TransferEntity> AddTransferAsync(TransferEntity transferEntity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransferEntity>> GetAllTransfersAsync()
        {
            throw new NotImplementedException();
        }
    }
}