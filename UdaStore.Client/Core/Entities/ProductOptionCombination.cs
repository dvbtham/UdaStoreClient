using System;
using System.Collections.Generic;

namespace UdaStore.Client.Core.Entities
{
    public partial class ProductOptionCombination
    {
        public long Id { get; set; }
        public long OptionId { get; set; }
        public long ProductId { get; set; }
        public int SortIndex { get; set; }
        public string Value { get; set; }

        public ProductOption Option { get; set; }
        public Product Product { get; set; }
    }
}
