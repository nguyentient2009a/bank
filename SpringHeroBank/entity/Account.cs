using System;

namespace SpringHeroBank.entity
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; } // 1. active, 2. de active, 3. lock
    }
}