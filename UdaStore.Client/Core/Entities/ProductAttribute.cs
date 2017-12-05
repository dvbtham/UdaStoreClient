using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductAttribute
    {
        public ProductAttribute()
        {
            CatalogProductAttributeValue = new HashSet<ProductAttributeValue>();
            CatalogProductTemplateProductAttribute = new HashSet<ProductTemplateProductAttribute>();
        }

        public long Id { get; set; }
        public long GroupId { get; set; }
        public string Name { get; set; }

        public ProductAttributeGroup Group { get; set; }
        public ICollection<ProductAttributeValue> CatalogProductAttributeValue { get; set; }
        public ICollection<ProductTemplateProductAttribute> CatalogProductTemplateProductAttribute { get; set; }
    }
}
