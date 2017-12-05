using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class UserRole
    {
        public long UserId { get; set; }
        public long RoleId { get; set; }

        public Role Role { get; set; }
        public User User { get; set; }
    }
}
