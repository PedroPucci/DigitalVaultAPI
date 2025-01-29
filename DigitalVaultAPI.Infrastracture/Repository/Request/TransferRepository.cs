using DigitalVaultAPI.Domain.Entities;
using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DigitalVaultAPI.Infrastracture.Repository.Request
{
    public class TransferRepository : ITransferRepository
    {
        private readonly DataContext _context;

        public TransferRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<TransferEntity> AddTransferAsync(TransferEntity transferEntity)
        {
            if (transferEntity is null)
                throw new ArgumentNullException(nameof(transferEntity), "TransferEntity cannot be null");

            var result = await _context.TransferEntity.AddAsync(transferEntity);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<List<TransferEntity>> GetAllTransfersAsync()
        {
            return await _context.TransferEntity
                .OrderBy(transferEntity => transferEntity.CreateDate)
                .Select(transferEntity => new TransferEntity
                {
                    Id = transferEntity.Id,
                    Description = transferEntity.Description
                }).ToListAsync();
        }
    }
}