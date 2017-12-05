using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class UserLogin
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public long UserId { get; set; }

        public User User { get; set; }
    }
}
