using DigitalVaultAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DigitalVaultAPI.Infrastracture.Connection
{
    public static class DataModelConfiguration
    {
        public static void ConfigureModels(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.HasKey(u => u.Id);
                entity.Property(u => u.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(u => u.Email)
                      .IsRequired()
                      .HasMaxLength(150);

                entity.Property(u => u.Password)
                      .IsRequired()
                      .HasMaxLength(255);               

                entity.HasOne(u => u.Balance)
                      .WithOne(b => b.User)
                      .HasForeignKey<BalanceEntity>(b => b.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<BalanceEntity>(entity =>
            {
                entity.HasKey(b => b.Id);

                entity.Property(b => b.CurrentBalance)
                      .HasColumnType("decimal(18, 2)")
                      .IsRequired();

                entity.HasOne(b => b.User)
                      .WithOne(u => u.Balance)
                      .HasForeignKey<BalanceEntity>(b => b.UserId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<TransferEntity>(entity =>
            {
                entity.HasKey(t => t.Id);

                entity.Property(t => t.Amount)
                      .HasColumnType("decimal(18, 2)")
                      .IsRequired();

                entity.Property(t => t.Status)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(t => t.Description)
                      .HasMaxLength(255);

                entity.HasOne(t => t.Sender)
                      .WithMany()
                      .HasForeignKey(t => t.SenderId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .IsRequired();

                entity.HasOne(t => t.Receiver)
                      .WithMany()
                      .HasForeignKey(t => t.ReceiverId)
                      .OnDelete(DeleteBehavior.Restrict)
                      .IsRequired();
            });
        }
    }
}