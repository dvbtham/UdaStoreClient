using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductMedia
    {
        public long Id { get; set; }
        public int DisplayOrder { get; set; }
        public long MediaId { get; set; }
        public long ProductId { get; set; }

        public Media Media { get; set; }
        public Product Product { get; set; }
    }
}
