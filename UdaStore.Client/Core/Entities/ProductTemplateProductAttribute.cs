using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductTemplateProductAttribute
    {
        public long ProductTemplateId { get; set; }
        public long ProductAttributeId { get; set; }

        public ProductAttribute ProductAttribute { get; set; }
        public ProductTemplate ProductTemplate { get; set; }
    }
}
