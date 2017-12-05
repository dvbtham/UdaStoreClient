using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class UserToken
    {
        public long UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public User User { get; set; }
    }
}
