using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class RoleClaim
    {
        public int Id { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public long RoleId { get; set; }

        public Role Role { get; set; }
    }
}
