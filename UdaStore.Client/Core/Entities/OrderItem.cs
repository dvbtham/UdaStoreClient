using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class OrderItem
    {
        public long Id { get; set; }
        public long? OrderId { get; set; }
        public long ProductId { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
