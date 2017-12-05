using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class StateOrProvince
    {
        public StateOrProvince()
        {
            CoreAddress = new HashSet<Address>();
            CoreDistrict = new HashSet<District>();
            OrdersOrderAddress = new HashSet<OrderAddress>();
        }

        public long Id { get; set; }
        public long CountryId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Country Country { get; set; }
        public ICollection<Address> CoreAddress { get; set; }
        public ICollection<District> CoreDistrict { get; set; }
        public ICollection<OrderAddress> OrdersOrderAddress { get; set; }
    }
}
