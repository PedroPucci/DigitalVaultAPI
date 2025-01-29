using DigitalVaultAPI.Domain.General;
using System.Text.Json.Serialization;

namespace DigitalVaultAPI.Domain.Entities
{
    public class TransferEntity : BaseEntity
    {
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; } = "pending";
        public string? Description { get; set; }

        [JsonIgnore]
        public UserEntity? Sender { get; set; }

        [JsonIgnore]
        public UserEntity? Receiver { get; set; }
    }
}