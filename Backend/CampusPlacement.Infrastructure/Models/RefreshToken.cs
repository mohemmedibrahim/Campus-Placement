using System;
using System.Collections.Generic;
using System.Text;

namespace CampusPlacement.Infrastructure.Identity
{
    public class RefreshToken
    {
        public int RefreshTokenId { get; set; }

        public string ApplicationUserId { get; set; } = string.Empty;

        public string TokenHash { get; set; } = string.Empty;

        public DateTime ExpiresAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? RevokedAt { get; set; }

        public string? ReplacedByTokenHash { get; set; }

        public ApplicationUser ApplicationUser { get; set; } = null!;
    }
}