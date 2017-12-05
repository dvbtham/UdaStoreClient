using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductCategory
    {
        public long Id { get; set; }
        public long CategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsFeaturedProduct { get; set; }
        public long ProductId { get; set; }

        public Category Category { get; set; }
        public Product Product { get; set; }
    }
}
