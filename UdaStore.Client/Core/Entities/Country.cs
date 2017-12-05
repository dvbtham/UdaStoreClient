using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class Country
    {
        public Country()
        {
            CoreAddress = new HashSet<Address>();
            CoreStateOrProvince = new HashSet<StateOrProvince>();
            OrdersOrderAddress = new HashSet<OrderAddress>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<Address> CoreAddress { get; set; }
        public ICollection<StateOrProvince> CoreStateOrProvince { get; set; }
        public ICollection<OrderAddress> OrdersOrderAddress { get; set; }
    }
}
