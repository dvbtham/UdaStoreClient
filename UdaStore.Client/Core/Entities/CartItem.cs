using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class CartItem
    {
        public long Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public long UserId { get; set; }

        public Product Product { get; set; }
        public User User { get; set; }
    }
}
