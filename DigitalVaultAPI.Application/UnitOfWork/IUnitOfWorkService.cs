using DigitalVaultAPI.Application.Services;

namespace DigitalVaultAPI.Application.UnitOfWork
{
    public interface IUnitOfWorkService
    {
        UserService UserService { get; }
        BalanceService BalanceService { get; }
        TransferService TransferService { get; }
    }
}