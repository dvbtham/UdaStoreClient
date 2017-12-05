using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductOption
    {
        public ProductOption()
        {
            CatalogProductOptionCombination = new HashSet<ProductOptionCombination>();
            CatalogProductOptionValue = new HashSet<ProductOptionValue>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductOptionCombination> CatalogProductOptionCombination { get; set; }
        public ICollection<ProductOptionValue> CatalogProductOptionValue { get; set; }
    }
}
