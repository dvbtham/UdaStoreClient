using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductAttributeGroup
    {
        public ProductAttributeGroup()
        {
            CatalogProductAttribute = new HashSet<ProductAttribute>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductAttribute> CatalogProductAttribute { get; set; }
    }
}
