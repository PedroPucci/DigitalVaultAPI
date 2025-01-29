using DigitalVaultAPI.Infrastracture.Connection;
using DigitalVaultAPI.Infrastracture.Repository.Interfaces;
using DigitalVaultAPI.Infrastracture.Repository.Request;
using Microsoft.EntityFrameworkCore.Storage;
using Serilog;

namespace DigitalVaultAPI.Infrastracture.Repository.RepositoryUoW
{
    public class RepositoryUoW : IRepositoryUoW
    {
        private readonly DataContext _context;
        private bool _disposed = false;
        private IUserRepository? _userRepository = null;
        private IBalanceRepository? _balanceRepository = null;
        private ITransferRepository? _transferRepository = null;

        public RepositoryUoW(DataContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository is null)
                {
                    _userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        public IBalanceRepository BalanceRepository
        {
            get
            {
                if (_balanceRepository is null)
                {
                    _balanceRepository = new BalanceRepository(_context);
                }
                return _balanceRepository;
            }
        }

        public ITransferRepository TransferRepository
        {
            get
            {
                if (_transferRepository is null)
                {
                    _transferRepository = new TransferRepository(_context);
                }
                return _transferRepository;
            }
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _context.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                Log.Error($"Database connection failed: {ex.Message}");
                throw new ApplicationException("Database is not available. Please check the connection.");
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}