using DigitalVaultAPI.Application.Services;
using DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW;

namespace DigitalVaultAPI.Application.UnitOfWork
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IRepositoryUoW _repositoryUoW;
        private UserService userService;
        private BalanceService balanceService;
        private TransferService transferService;

        public UnitOfWorkService(IRepositoryUoW repositoryUoW)
        {
            _repositoryUoW = repositoryUoW;
        }

        public UserService UserService
        {
            get
            {
                if (userService is null)
                {
                    userService = new UserService(_repositoryUoW);
                }
                return userService;
            }
        }

        public BalanceService BalanceService
        {
            get
            {
                if (balanceService is null)
                {
                    balanceService = new BalanceService(_repositoryUoW);
                }
                return balanceService;
            }
        }

        public TransferService TransferService
        {
            get
            {
                if (transferService is null)
                {
                    transferService = new TransferService(_repositoryUoW);
                }
                return transferService;
            }
        }
    }
}