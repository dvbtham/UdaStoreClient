using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductAttributeValue
    {
        public long Id { get; set; }
        public long AttributeId { get; set; }
        public long ProductId { get; set; }
        public string Value { get; set; }

        public ProductAttribute Attribute { get; set; }
        public Product Product { get; set; }
    }
}
