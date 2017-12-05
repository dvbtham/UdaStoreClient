using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class UserClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
    }
}
