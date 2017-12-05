using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductTemplate
    {
        public ProductTemplate()
        {
            CatalogProductTemplateProductAttribute = new HashSet<ProductTemplateProductAttribute>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductTemplateProductAttribute> CatalogProductTemplateProductAttribute { get; set; }
    }
}
