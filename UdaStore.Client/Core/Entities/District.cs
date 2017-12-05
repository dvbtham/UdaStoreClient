using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class District
    {
        public District()
        {
            CoreAddress = new HashSet<Address>();
            OrdersOrderAddress = new HashSet<OrderAddress>();
        }

        public long Id { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }
        public long StateOrProvinceId { get; set; }
        public string Type { get; set; }

        public StateOrProvince StateOrProvince { get; set; }
        public ICollection<Address> CoreAddress { get; set; }
        public ICollection<OrderAddress> OrdersOrderAddress { get; set; }
    }
}
