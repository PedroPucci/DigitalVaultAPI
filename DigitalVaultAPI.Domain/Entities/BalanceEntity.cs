using DigitalVaultAPI.Domain.General;
using System.Text.Json.Serialization;

namespace DigitalVaultAPI.Domain.Entities
{
    public class BalanceEntity : BaseEntity
    {
        public Guid UserId { get; set; }
        public decimal CurrentBalance { get; set; } = 0;

        [JsonIgnore]
        public UserEntity? User { get; set; }
    }
}