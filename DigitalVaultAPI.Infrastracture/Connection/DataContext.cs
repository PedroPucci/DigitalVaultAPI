﻿using DigitalVaultAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DigitalVaultAPI.Infrastracture.Connection
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }       
        
        public DbSet<UserEntity> UserEntity { get; set; }
        public DbSet<BalanceEntity> Balanceentity { get; set; }
        public DbSet<TransferEntity> TransferEntity { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataModelConfiguration.ConfigureModels(modelBuilder);
        }        
    }
}
