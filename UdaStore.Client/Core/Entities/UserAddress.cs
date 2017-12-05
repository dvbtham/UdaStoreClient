using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class UserAddress
    {
        public UserAddress()
        {
            CoreUserDefaultBillingAddress = new HashSet<User>();
            CoreUserDefaultShippingAddress = new HashSet<User>();
        }

        public long Id { get; set; }
        public long AddressId { get; set; }
        public int AddressType { get; set; }
        public DateTimeOffset? LastUsedOn { get; set; }
        public long UserId { get; set; }

        public Address Address { get; set; }
        public User User { get; set; }
        public ICollection<User> CoreUserDefaultBillingAddress { get; set; }
        public ICollection<User> CoreUserDefaultShippingAddress { get; set; }
    }
}
