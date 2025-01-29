using DigitalVaultAPI.Infrastracture.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.Storage;

namespace DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW
{
    public interface IRepositoryUoW
    {
        IUserRepository UserRepository { get; }
        IBalanceRepository BalanceRepository { get; }
        ITransferRepository TransferRepository { get; }

        Task SaveAsync();
        void Commit();
        IDbContextTransaction BeginTransaction();
    }
}