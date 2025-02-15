﻿using DigitalVaultAPI.Domain.General;

namespace DigitalVaultAPI.Domain.Entities
{
    public class UserEntity : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public BalanceEntity? Balance { get; set; }
    }
}