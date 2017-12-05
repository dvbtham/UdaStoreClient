using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Role
    {
        public Role()
        {
            CoreRoleClaim = new HashSet<RoleClaim>();
            CoreUserRole = new HashSet<UserRole>();
        }

        public long Id { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public ICollection<RoleClaim> CoreRoleClaim { get; set; }
        public ICollection<UserRole> CoreUserRole { get; set; }
    }
}
