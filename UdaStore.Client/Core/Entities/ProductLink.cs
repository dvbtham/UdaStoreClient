using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductLink
    {
        public long Id { get; set; }
        public int LinkType { get; set; }
        public long LinkedProductId { get; set; }
        public long ProductId { get; set; }

        public Product LinkedProduct { get; set; }
        public Product Product { get; set; }
    }
}
